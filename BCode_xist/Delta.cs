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
namespace BCode_xist
{
	internal static class Delta
	{
		public enum CodeType: int
		{
			//Code39 = 4      'Code 39 1D format.
			//Code93 = 8      'Code 93 1D format.
			Code128 = 16, //Code 128 1D format.
			//DataMatrix = 32 'Data Matrix 2D barcode format.
			//Pdf417 = 1024   'PDF417 format.
			QRCode = 2048 //QR Code 2D barcode format.
		}
		public static Factors fact;
		public static ZXing.Common.EncodingOptions EncodingOptions;
		public static ZXing.Rendering.IBarcodeRenderer<Bitmap> Renderer;
		//Public Function optPDF_417() As PDF417.PDF417EncodingOptions
		//Dim options = New PDF417.PDF417EncodingOptions
		//   With options
		//      .Width = fact.Width
		//      .Height = fact.Height
		//     .GS1Format = fact.GS1
		//     .Margin = fact.Margin
		//    .PureBarcode = fact.PureBarcode
		//   .ErrorCorrection = fact.Pdf417ErrorCorrection
		//    .CharacterSet = getCharset(fact.CharacterSet.ToString)
		//     .Compact = fact.Pdf417Compact
		//     .Compaction = fact.Pdf417Compaction
		// End With
		// Return options
		//End Function
		public static ZXing.QrCode.QrCodeEncodingOptions optQR_CODE()
		{
			var options = new ZXing.QrCode.QrCodeEncodingOptions();
			options.Width = fact.Width;
			options.Height = fact.Height;
			options.GS1Format = fact.GS1;
			options.Margin = fact.Margin;
			options.PureBarcode = fact.PureBarcode;
			string erCr = fact.ErrorCorrection.ToString();
			switch (erCr)
			{
				case "L": //7%
					options.ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.L;
					break;
				case "M": //15%
					options.ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.M;
					break;
				case "Q": //25%
					options.ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.Q;
					break;
				case "H": //30%
					options.ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.H;
					break;
			}
			options.CharacterSet = getCharset(fact.CharacterSet.ToString()); // s
			return options;
		}
		//Public Function optDATA_MATRIX() As Datamatrix.DatamatrixEncodingOptions
		//Dim options = New Datamatrix.DatamatrixEncodingOptions
		//    With options
		//       .Width = fact.Width
		//       .Height = fact.Height
		//       .GS1Format = fact.GS1
		//       .Margin = fact.Margin
		//       .PureBarcode = fact.PureBarcode
		//       .SymbolShape = fact.DataMatrixShape
		//  End With
		//  Return options
		//End Function

		public static ZXing.OneD.Code128EncodingOptions optCODE_128()
		{
			var options = new ZXing.OneD.Code128EncodingOptions();
			options.Width = fact.Width;
			options.Height = fact.Height;
			options.GS1Format = fact.GS1;
			options.Margin = fact.Margin;
			options.PureBarcode = fact.PureBarcode;
			options.ForceCodesetB = true;
			return options;
		}
		private static string getCharset(string ss)
		{
			switch (ss)
			{
				case "ASCII":
					ss = "US-ASCII";
					break;
				default:
					ss = ss.Replace('_', '-');
					break;
			}
			return ss;
		}

		public static Bitmap loadBitmap(string fileName)
		{
			if (! (System.IO.File.Exists(fileName)))
			{
				return null;
			}
			using (Bitmap bm = new Bitmap(fileName))
			{
				return new Bitmap(bm);
			}
		}
	}
} //end of root namespace
