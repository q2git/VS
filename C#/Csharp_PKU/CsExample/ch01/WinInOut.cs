using System;
using System.Windows.Forms;
using System.Drawing;
public class  WinInOut : Form
{
	TextBox txt = new TextBox();
	Button btn = new Button();
	Label lbl = new Label();

	public void init()
	{
		this.Controls.Add( txt );
		this.Controls.Add( btn );
		this.Controls.Add( lbl );
		txt.Dock = System.Windows.Forms.DockStyle.Top;
		btn.Dock = System.Windows.Forms.DockStyle.Fill;
		lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
		btn.Text = "��ƽ��";
		lbl.Text = "������ʾ����ı�ǩ";
		this.Size = new Size( 300,120 );

		btn.Click += new System.EventHandler (this.button1_Click); 
	}

	public void button1_Click( object sender, EventArgs e )
	{
		string s = txt.Text;
		double d = Double.Parse( s );
		double sq = d * d;
		lbl.Text = d + "��ƽ���ǣ�" + sq;
	}

	static void Main()
	{
		WinInOut f = new WinInOut();
		f.Text = "WinInOut";
		f.init();
		Application.Run( f );
	}
}
