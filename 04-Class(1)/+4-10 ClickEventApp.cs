//using System;
//using System.Windows.Forms;

//class ClickEventApp : Form // Form 클래스 상속
//{
//    public ClickEventApp()
//    {
//        this.Text = "ClickEventApp";
//        this.Click += new EventHandler(ClickEvent); // 이벤트에 이벤트 처리기를 등록 
//    }

//    // .NET 프레임워크에 이미 정의된 System.EventHandler 델리게이트를 이벤트에 사용하는 것을 권고
//    private void ClickEvent(object sender, EventArgs e)
//    {
//        MessageBox.Show("sender = " + sender.GetType());
//    }
//    public static void Main()
//    {
//        Application.Run(new ClickEventApp());
//    }
//}