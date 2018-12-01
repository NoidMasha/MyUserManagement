


namespace MyUserManagement.Infrastructure
{
    class BaseTextBox:System.Windows.Forms.TextBox
    {
        private System.Drawing.Font oldFont = null;
        private bool waterMarkTextEnabled = false;

        #region Attributes 
        private System.Drawing.Color waterMarkColor = System.Drawing.Color.Gray;
        public System.Drawing.Color WaterMarkColor
        {
            get { return waterMarkColor; }
            set
            {
                waterMarkColor = value;
                Invalidate();
            }
        }

        private string waterMarkText = "Water Mark";
        public string WaterMarkText
        {
            get { return waterMarkText; }
            set
            {
                waterMarkText = value;
                Invalidate();
            }
        }
        #endregion \Attributes

        //Default constructor
        public BaseTextBox()
        {
            JoinEvents(true);
        }

        //Override OnCreateControl 
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            WaterMark_Toggel(null, null);
        }
        
        //Override OnPaint
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs args)
        {
            // Use the same font that was defined in base class
            System.Drawing.Font drawFont = new System.Drawing.Font(Font.FontFamily,
                Font.Size, Font.Style | System.Drawing.FontStyle.Italic, Font.Unit);
            //Create new brush with gray color or 
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(WaterMarkColor);//use Water mark color
            //Draw Text or WaterMark
            args.Graphics.DrawString((waterMarkTextEnabled ? WaterMarkText : Text),
                drawFont, drawBrush, new System.Drawing.PointF(0.0F, 0.0F));
            base.OnPaint(args);
        }

        private void JoinEvents(bool join)
        {
            if (join)
            {
                this.TextChanged += new System.EventHandler(this.WaterMark_Toggel);
                this.LostFocus += new System.EventHandler(this.WaterMark_Toggel);
                this.FontChanged += new System.EventHandler(this.WaterMark_FontChanged);
            }
        }

        private void WaterMark_Toggel(object sender, System.EventArgs args)
        {
            if (this.Text.Length <= 0)
                EnableWaterMark();
            else
                DisbaleWaterMark();
        }

        private void EnableWaterMark()
        {
            //Save current font until returning the UserPaint style to false (NOTE:
            //It is a try and error advice)
            oldFont = new System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style,
               Font.Unit);
            //Enable OnPaint event handler
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint, true);
            this.waterMarkTextEnabled = true;
            //Triger OnPaint immediatly
            Refresh();
        }

        private void DisbaleWaterMark()
        {
            //Disbale OnPaint event handler
            this.waterMarkTextEnabled = false;
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint, false);
            //Return back oldFont if existed
            if (oldFont != null)
                this.Font = new System.Drawing.Font(oldFont.FontFamily, oldFont.Size,
                    oldFont.Style, oldFont.Unit);
        }

        private void WaterMark_FontChanged(object sender, System.EventArgs args)
        {
            if (waterMarkTextEnabled)
            {
                oldFont = new System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style,
                    Font.Unit);
                Refresh();
            }
        }

    }
}
