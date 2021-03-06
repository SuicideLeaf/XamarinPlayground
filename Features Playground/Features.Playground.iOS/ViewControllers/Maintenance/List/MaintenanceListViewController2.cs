// This file has been autogenerated from a class added in the UI designer.

using System;
using Features.Playground.Core.Classes;
using Features.Playground.iOS.Sources.Maintenance;
using UIKit;

namespace Features.Playground.iOS.ViewControllers.Maintenance.List
{
	public partial class MaintenanceListViewController2 : UIViewController
	{
		private Enums.MaintenanceStatus _maintenanceStatus;

		public MaintenanceListViewController2( IntPtr handle ) : base( handle )
		{
		}

		public override void ViewDidLoad( )
		{
			base.ViewDidLoad( );

			ConfigureNavigationBar( );
			ConfigureTableView( );
		}

		public override void ViewDidAppear( bool animated )
		{
			base.ViewDidAppear( animated );

			MaintenanceTableView.DeselectRow( MaintenanceTableView.IndexPathForSelectedRow, true );
		}

		private void ConfigureNavigationBar( )
		{
			string navigationBarTitle = "{0} Maintenance";

			switch ( _maintenanceStatus )
			{
				case Enums.MaintenanceStatus.Incomplete:
					navigationBarTitle = string.Format( navigationBarTitle, "Incomplete" );
					break;
				case Enums.MaintenanceStatus.Complete:
					navigationBarTitle = string.Format( navigationBarTitle, "Completed" );
					break;
				case Enums.MaintenanceStatus.Requested:
					navigationBarTitle = string.Format( navigationBarTitle, "Requested" );
					break;
				default:
					navigationBarTitle = "Maintenance";
					break;
			}

			NavigationItem.Title = navigationBarTitle;
			NavigationItem.BackBarButtonItem = new UIBarButtonItem( "", UIBarButtonItemStyle.Plain, null );
		}

		public void SetMaintenanceStatus( Enums.MaintenanceStatus status )
		{
			_maintenanceStatus = status;
		}

		private void ConfigureTableView( )
		{
			MaintenanceTableView.Source = new MaintenanceTableViewSource( _maintenanceStatus );
		}
	}
}