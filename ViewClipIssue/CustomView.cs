using System;
using Microsoft.Maui.Controls.Shapes;

namespace ViewClipIssue
{
    public class CutomView : Grid
    { 
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            // Set the Clip property using the size information
            if (width > 0 && height > 0)
            {
                this.Clip = new RoundRectangleGeometry(25, new Rect(0, 0, width, height));
            }
        }
    }
}
