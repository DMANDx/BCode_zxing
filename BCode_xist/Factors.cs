using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using System.ComponentModel;
using ZXing;
namespace BCode_xist
{
	public enum ErrCorrectionLevel: int
	{
		L,
		M,
		Q,
		H
	}
	public enum CharSet: int
	{
		ASCII,
		ISO_8859_1,
		ISO_8859_5,
		ISO_8859_15,
		windows_1250,
		windows_1251,
		windows_1252,
		UTF_8
	}
	public class Factors
	{
		public Factors()
		{
			Width = 336;
			Height = 80;
			PureBarcode = true;
			ErrorCorrection = ErrCorrectionLevel.L;
			//_CharacterSet = CharSet.ISO_8859_1
			CharacterSet = CharSet.UTF_8;
			Margin = 10;
			//_Pdf417Compact = False
			//_Pdf417Compaction = PDF417.Internal.Compaction.AUTO
			//_Pdf417ErrorCorrection = PDF417.Internal.PDF417ErrorCorrectionLevel.L0
			//_DataMatrixShape = Datamatrix.Encoder.SymbolShapeHint.FORCE_NONE
			GS1 = false;
		}
		[Description("ширина изображения, px")]
		public int Width {get; set;}
		[Description("высота изображения, px")]
		public int Height {get; set;}
		[Description("true - не включать значение в изображение")]
		public bool PureBarcode {get; set;}
		[Description("степень коррекции ошибок"), Category("QRCode")]
		public ErrCorrectionLevel ErrorCorrection {get; set;}
		[Description("кодировка символов")]
		public CharSet CharacterSet {get; set;}
		[Description("в зависимости от формата (до и после штрих-кода по горизонтали для большинства 1D-форматов, в px)")]
		public int Margin {get; set;}
		//<Description("следует ли использовать компактный режим для PDF417"),
		//            Category("Pdf417")>
		//Public Property Pdf417Compact As Boolean
		//<Description("режим уплотнения для PDF417"),
		//    Category("Pdf417")>
		//Public Property Pdf417Compaction As PDF417.Internal.Compaction
		//<Description("степень коррекции ошибок Pdf417"),
		//    Category("Pdf417")>
		//Public Property Pdf417ErrorCorrection As PDF417.Internal.PDF417ErrorCorrectionLevel
		//<Description("определяет матричную форму для матрицы данных"),
		//   Category("Matrix")>
		//Public Property DataMatrixShape As Datamatrix.Encoder.SymbolShapeHint
		[Description("использовать стандарт GS1 (General Specifications)")]
		public bool GS1 {get; set;}
	}
} //end of root namespace
