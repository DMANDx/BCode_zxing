using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using ZXing;
using System.Drawing.Imaging;
using System.IO;
namespace BCode_xist
{
	public partial class Form1
	{
		internal Form1()
		{
			InitializeComponent();
		}
		private Type Renderer {get; set;}
		private string basePath;
		private string fName;
		private Bitmap bmg;
		private void Form1_Load(object sender, System.EventArgs e)
		{
			basePath = Path.Combine(Application.StartupPath, "BImage");
			this.Text = "BCode by XIST v." + My.MyApplication.Application.Info.Version.Major + "." + My.MyApplication.Application.Info.Version.Minor;
			Delta.fact = new Factors();
			PropertyGrid1.SelectedObject = Delta.fact;
			DeltaType();
			ComboBox1_SelectionChangeCommitted(sender, e);
			Delta.EncodingOptions = new ZXing.Common.EncodingOptions {Height = PictureBox1.Height, Width = PictureBox1.Width};
            //Delta.Renderer = (ZXing.Rendering.IBarcodeRenderer<Bitmap>)typeof(ZXing.Rendering.BitmapRenderer);
            Renderer = typeof(ZXing.Rendering.BitmapRenderer);
        }
		public void DeltaType()
		{
			ComboBox1.DataSource = Enum.GetNames(typeof(Delta.CodeType));
			ComboBox1.SelectedIndex = 0;
		}
		private void ComboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			if (ComboBox1.Text == "Code128")
			{
				TextBox1.Text = "Код стандарта Code 128 является не только более плотным штрих-кодом по сравнению с большинством других, но и также самым универсальным в категории 1d. Его название происходит из факта, что Code 128 имеет возможность кодировать все 128 символов ASCII. Наряду с буквами и цифрами сюда входят и знаки препинания, символы, и т.д. Данный стандарт кодирования наиболее часто используется в таких логистических видах деятельности, как закупка и доставка, но может потенциально применяться для многих других целей.";
			}
			else
			{
				TextBox1.Text = "QRCode (Quick Response Code — код быстрого реагирования) использует четыре стандартизированных режима кодирования:" + "Цифровой: 10 битов на три цифры, до 7089 цифр.Алфавитно-цифровой: поддерживаются 10 цифр, буквы от A до Z и несколько спецсимволов. 11 битов на два символа, до 4296 символов. Байтовый: данные в любой подходящей кодировке (по умолчанию ISO 8859-1), до 2953 байт.Кандзи: 13 битов на иероглиф, до 1817 иероглифов.Код состоит из чёрных квадратов, расположенных в квадратной сетке на белом фоне, которые могут считываться с помощью устройств обработки изображений, таких как камера. Есть четыре уровня избыточности: 7, 15, 25 и 30 %.QR-код разработан и представлен японской компанией Denso-Wavehttps в 1994 году." + "Основное достоинство QR-кода — это лёгкое распознавание сканирующим оборудованием, что даёт возможность использования в торговле, производстве, логистике. Максимальное количество символов, которые помещаются в один QR-код:" + "цифры десятичной системы счисления — 7089;цифры десятичной системы счисления и буквы (латиница) — 4296;	байты — 2953 (следовательно, около 2953 букв кириллицы в кодировке windows-1251 или около 1450 букв кириллицы в utf-8);" + "иероглифы — 1817.";
			}
		}
		private void Button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				int bcode = Convert.ToInt32(Enum.Parse(typeof(Delta.CodeType), (string)ComboBox1.SelectedItem));
				switch (bcode)
				{
					case (int)BarcodeFormat.QR_CODE:
						Delta.EncodingOptions = Delta.optQR_CODE();
						break;
					case (int)BarcodeFormat.CODE_128:
					case (int)BarcodeFormat.CODE_93:
					case (int)BarcodeFormat.CODE_39:
						Delta.EncodingOptions = Delta.optCODE_128();
						break;
				}

                //var writer = new BarcodeWriter
                //            { Format = (BarcodeFormat)bcode, Options = Delta.EncodingOptions,
				//            Renderer = (ZXing.Rendering.IBarcodeRenderer<Bitmap>)Activator.CreateInstance((Type)Delta.Renderer) };

                var writer = new BarcodeWriter
                { Format = (BarcodeFormat)bcode, Options = Delta.EncodingOptions};

                bmg = writer.Write(TextBox2.Text);
				PictureBox1.Image = bmg;

			}
			catch (Exception exc)
			{
				MessageBox.Show(this, exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void Button2_Click(object sender, System.EventArgs e)
		{
			
			if (PictureBox1.Image != null)
			{				
				int bcode = Convert.ToInt32(Enum.Parse(typeof(Delta.CodeType), (string)ComboBox1.SelectedItem));
				switch (bcode)
				{
					case (int)BarcodeFormat.QR_CODE:
					{
						string pth = Path.Combine(basePath, "QR_" + TextBox2.Text + ".png");
						bmg.Save(pth, ImageFormat.Png);
						break;
					}
					default:
					{
						string pth = Path.Combine(basePath, "128_" + TextBox2.Text + ".png");
						bmg.Save(pth, ImageFormat.Png);
						break;
					}
				}
			}			
		}

	private static Form1 _DefaultInstance;
	public static Form1 DefaultInstance
	{
		get
		{
			if (_DefaultInstance == null)
				_DefaultInstance = new Form1();

			return _DefaultInstance;
		}
	}
	}

} //end of root namespace
