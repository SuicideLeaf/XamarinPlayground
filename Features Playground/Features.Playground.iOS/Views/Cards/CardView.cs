// This file has been autogenerated from a class added in the UI designer.

using System;
using CoreGraphics;
using UIKit;

namespace Features.Playground.iOS.Views.Cards
{
	public partial class CardView : UIView
	{
		public CardView( IntPtr handle ) : base( handle )
		{
		}

		public override void AwakeFromNib( )
		{
			base.AwakeFromNib( );

			Layer.CornerRadius = 5f;
			Layer.ShadowOffset = new CGSize( 0, 2 );
			Layer.ShadowOpacity = 0.25f;
			Layer.ShadowRadius = 4;
			Layer.ShadowColor = UIColor.Black.CGColor;
			Layer.ShouldRasterize = true;
			Layer.RasterizationScale = UIScreen.MainScreen.Scale;
		}
	}
}