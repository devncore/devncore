﻿using System.Windows.Input;
using DevNcore.WPF.Leagueoflegends.LayoutSupport.Foundation.Riotbase;

namespace DevNcore.WPF.Leagueoflegends.LayoutSupport.Controls.Primitives
{
    public class BaseWindow : RiotWindow
    {
        #region OnApplyTemplate

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if (GetTemplateChild("PART_DragBar") is DragBorder bar)
            {
                bar.MouseDown += Bar_MouseDown;
            }
        }
        #endregion

        #region Bar_MouseDown

        private void Bar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                GetWindow(this).DragMove();
            }
        }
        #endregion
    }
}
