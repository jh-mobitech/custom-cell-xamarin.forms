﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App363.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(ViewCell), typeof(StandardViewCellRenderer))]
namespace App363.iOS
{
    class StandardViewCellRenderer : ViewCellRenderer
    {
        public override UIKit.UITableViewCell GetCell(Cell item,
     UIKit.UITableViewCell reusableCell, UIKit.UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);

            Console.WriteLine(item.StyleId);

            cell.Accessory = UIKit.UITableViewCellAccessory.None;

       //     switch (item.StyleId)
       //     {
       //         case "none":
       //             cell.Accessory = UIKit.UITableViewCellAccessory.None;
       //             break;
       //         case "checkmark":
       //             cell.Accessory = UIKit.UITableViewCellAccessory.Checkmark;
       //             break;
       //         case "detail-button":
       //             cell.Accessory =
       //       UIKit.UITableViewCellAccessory.DetailButton;
       //             break;
       //         case "detail-disclosure-button":
       //             cell.Accessory =
       //UIKit.UITableViewCellAccessory.DetailDisclosureButton;
       //             break;
       //         case "disclosure":
       //         default:
       //             cell.Accessory =
       //     UIKit.UITableViewCellAccessory.DisclosureIndicator;
       //             break;
       //     }
            return cell;
        }
    }
}