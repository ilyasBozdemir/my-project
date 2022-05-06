using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopLibrary.DesktopLibrary.Forms
{
    
    public class DraggableControl
    {
        bool DragState = false;
        int oldX = 0, oldY = 0;
        public void addControl(Control control, bool Isdraggable)
        {
            if (Isdraggable)
            {
                control.MouseDown += Control_MouseDown;// olayları bağla
                control.MouseMove += Control_MouseMove;// olayları bağla
                control.MouseUp += Control_MouseUp;// olayları bağla
            }
        }
        private void Control_MouseUp(object sender, MouseEventArgs e)//mouse tuşunu bırakınca olay fırlatılır.
        {
            DragState = false;//farenin butonunu bırakınca "false" olur.
        }
        private void Control_MouseMove(object sender, MouseEventArgs e)
            //mouse control üzerinde hareket ederse bırakınca olay fırlatılır.
        {
            if (DragState)//tuşa tıklanıldı mı ?
            {
                int newX = (e.Location.X + ((Control)sender).Location.X) - oldX;
                // newX değeri =( farenin X değeri + Controlün X değeri ) - farenin tıklanırken ki X değeri  
                int newY = (e.Location.Y + ((Control)sender).Location.Y) - oldY;
                // newY değeri =( farenin Y değeri + Controlün Y değeri ) - farenin tıklanırken ki Y değeri  
                ((Control)sender).Location = new Point(newX, newY);
                // Controlün yeni koordinatı Point(X, Y)'dir
            }
        }
        private void Control_MouseDown(object sender, MouseEventArgs e)//mouse tıklanınca bırakınca olay fırlatılır.
        {
            DragState = true;//tuşa tıklanınca true değerini alır.
            oldX = e.Location.X;//olay tetiklendiğinde farenin yatay koordinatı alınır.
            oldY = e.Location.Y;//olay tetiklendiğinde farenin dikey koordinatı alınır.
        }
    }
}
