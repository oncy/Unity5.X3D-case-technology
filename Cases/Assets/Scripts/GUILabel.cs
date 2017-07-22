using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUILabel : MonoBehaviour {
	public Texture2D textureToDisplay;
	public Texture2D aTexture;
	public Texture btnTexture;
	public string passwordToEdit = "My Password";
	public string stringToEdit = "Hello World\nI've got 2 lines";
	public string login1 = "username";
	public string login2 = "no action here";
	public string pwd = "a pwd";
	//private bool toogleTxt = false;
	//private bool toogleImg = false;
	public int toolbarInt = 0;
	public string[] toolbarStrings = new string[]{"Toolbar1","Toolbar2","Toolbar3" };
	public int selGridInt = 0;
	public string[] selStrings = new string[]{"Grid1","Grid2","Grid3","Grid4"};
	public float hSliderValue = 0.0f;
	public float vSliderValue = 0.0f;
	public float hSbarValue;
	public float vSbarValue;
	public Vector2 scrollPosition = Vector2.zero;
	public Vector2 scrollPos = Vector2.zero;
	public Rect windowRect = new Rect (20, 20, 120, 50);
	public Rect windowRect2 = new Rect (20, 100, 120, 50);
	public bool doWindows = true;

	void Start () {
		
	}
	
	void Update () {
		
	}

	void OnGUI(){

		//GUI.Label(new Rect(Screen.width /10 , Screen.height /10 , Screen.width /5 ,Screen.height /10) ,"Hello !");
		//GUI.Label (new Rect (0,0, textureToDisplay.width, textureToDisplay.height), textureToDisplay);
		//drawtexture用于绘制一副指定的纹理图，一般情况下创建此控件对象采用静态方法（位置，纹理，缩放模式，图片混合模式，长宽比）
		//缩放纹理，保持高宽比，以便它完全适配在矩形内的位置传递给GUI.DrawTexture
		//q2wsswzzw2zweedswwwqqwasZGUI.DrawTexture (new Rect (Screen.width / 10, Screen.height / 10, Screen.width / 5, Screen.height / 5), aTexture, ScaleMode.ScaleToFit, true, 0.0f);

		//DrawTextureWithTexCoords控件用于在给定的坐标系内绘制一副纹理图，一般静态(位置，纹理，伸缩比例，使用使用默认alpha渲染管线
		//static void DrawTextureWithCoords(Rect rect ,Texture img ,Rect textRect,bool b)

		//if (!btnTexture) {
		//	Debug.LogError ("Please assign a texture in the inspector");
		//	return;
		//}
		//if (GUI.Button (new Rect (Screen.width / 10, Screen.height / 10, Screen.width / 10, Screen.height / 10), btnTexture))
		//	Debug.Log ("Clicked the button with an image");
		
		//if (GUI.Button (new Rect (Screen.width / 10, Screen.height / 3, Screen.width / 5, Screen.height / 10), "Click"))
		//	Debug.Log ("Clicked the button with an text");
			
		//绘制一个密码编辑框，并用*来屏蔽，最大长度25
		//passwordToEdit = GUI.PasswordField(new Rect(Screen.width /10 , Screen.height /10 , Screen.width /2 ,Screen.height /10),passwordToEdit,"0"[0],25);
		//绘制一个多行文本编辑框，最大200
		//stringToEdit = GUI.TextArea(new Rect(Screen.width /10 , Screen.height /5 , Screen.width /2 ,Screen.height /2),stringToEdit,200);

		//SetNextControlName控件用于给下一步控制设置事件名字
		//GetNameFousedControl控件用于得到当前控制焦点的名字
		//GUI.SetNextControlName("user");
		//绘制一个单行文本框
		//login1 = GUI.TextField(new Rect(Screen.width /10 , Screen.height /10 , Screen.width /3 ,Screen.height /10),login1);
		//login2 = GUI.TextField(new Rect(Screen.width /10 , Screen.height /3 , Screen.width /3 ,Screen.height /10),login2);
		//if(Event.current.Equals(Event.KeyboardEvent("return"))&&GUI.GetNameOfFocusedControl() == "user")
		//	Debug.Log("user");
		//if(GUI.Button(new Rect(Screen.width /2 , Screen.height /10 , Screen.width /5 ,Screen.height /10),"Login"))
		//    Debug.Log("Login");

		//GUI.SetNextControlName ("MyTextField");
		//login1 = GUI.TextField(new Rect(Screen.width /10 , Screen.height /10 , Screen.width /3 ,Screen.height /10),login1);
		//pwd = GUI.TextField(new Rect(Screen.width /10 , Screen.height /4 , Screen.width /3 ,Screen.height /10),pwd);
		//if (GUI.Button (new Rect (Screen.width / 10, Screen.height / 5 * 2, Screen.width / 6, Screen.height / 10), "Move Focus"))
		//	GUI.FocusControl ("MyTextField");

		//toogle用于绘制一个开关
		//if(!aTexture){
		//	Debug.LogError ("Please assign a texture in the inspector");
		//	return;
		//}
		//绘制一个名为A Toggle text 且初始状态为toggletxt的开关
		//toogleTxt =GUI.Toggle(new Rect (Screen.width / 10, Screen.height / 10, Screen.width / 3, Screen.height / 10),toogleTxt,"A Toggle text");
		//toogleImg = GUI.Toggle (new Rect (Screen.width / 10, Screen.height / 4, Screen.width / 10, Screen.height / 10), toogleImg, aTexture);

		//绘制一个内容为toolbarStrings且焦点在第toolbarInt上的工具条
		//toolbarInt = GUI.Toolbar(new Rect (Screen.width / 10, Screen.height / 10, Screen.width / 2, Screen.height / 10), toolbarInt,toolbarStrings);
		//网格按钮
		//selGridInt = GUI.SelectionGrid(new Rect (Screen.width / 10, Screen.height / 5, Screen.width / 2, Screen.height / 3), selGridInt,selStrings,2);
		//水平滚动条
		//hSliderValue = GUI.HorizontalSlider(new Rect (Screen.width / 10, Screen.height /20, Screen.width / 3, Screen.height / 10),hSliderValue ,0.0f,10.0f);
		//垂直滑杆
		//vSliderValue = GUI.VerticalSlider(new Rect (Screen.width / 20, Screen.height /20, Screen.width / 3, Screen.height / 5),vSliderValue ,10.0F,0.0F);
		//水平滚动条，可以自己设置阈值
		//hSbarValue = GUI.HorizontalScrollbar(new Rect (Screen.width / 10, Screen.height /1.8f, Screen.width / 3, Screen.height / 10),hSbarValue ,1.0f,0.0F,10.0F);
		//垂直滚蛋、阈值
		//vSbarValue = GUI.HorizontalScrollbar(new Rect (Screen.width / 10, Screen.height /1.8f, Screen.width / 3, Screen.height / 10),vSbarValue ,1.0f,10.0F,0.0F);
		//GUI.BeginGroup(new Rect(Screen.width / 2 ,Screen.height / 2 +100,400,200));
		//GUI.Box (new Rect (0, 0, 400, 200), "This box is now centered! - here you would put your main menu");
		//GUI.EndGroup ();//结束这个组

		//scrollPosition = GUI.BeginScrollView (new Rect (Screen.width / 10, Screen.height / 10, Screen.width / 4, Screen.height / 3), scrollPosition, new Rect (0, 0, Screen.width / 2, Screen.height / 2));
		//GUI.Button (new Rect (0, 0, 100, 20), "Top-left");
		//GUI.Button (new Rect (120, 0, 100, 20), "Top-right");
		//GUI.Button (new Rect (0, 120, 100, 20), "Button-left");
		//GUI.Button (new Rect (120, 120, 100, 20), "Button-right");
		//GUI.EndScrollView ();  //撤销滚动视图

		//scrollPos = GUI.BeginScrollView (new Rect (Screen.width / 10, Screen.height / 10, Screen.width / 5, Screen.height / 4), scrollPos, new Rect (0, 0, Screen.width / 2, Screen.height / 10));
		//if(GUI.Button(new Rect(0,0,Screen.width / 5, Screen.height / 10) ,"Go Right"))
		//	GUI.ScrollTo(new Rect( Screen.width /4 ,0 ,Screen.width /4 , Screen.height /10));
		//if(GUI.Button(new Rect(Screen.width / 4,0,Screen.width / 5, Screen.height / 10) ,"Go Left"))
		//	GUI.ScrollTo(new Rect( 0,0 ,Screen.width / 5 , Screen.height /10));
		//GUI.EndScrollView ();

		//绘制窗口
		//windowRect = GUI.Window(0,windowRect,DoMyWindow,"My Windows");
		//windowRect2 = GUI.Window(1,windowRect2,DoMyWindow,"My Windows");

		doWindows = GUI.Toggle (new Rect (10, 30, 80, 20), doWindows, "windows");
		if (doWindows) {
			GUI.Window (0, new Rect (100, 10, 200, 60), Dowindows, "Basic Window");
		}




	}
	void Dowindows(int windowsID){
		GUI.Button (new Rect (10, 30, 80, 20), "Click Me!");
	}

	void DoMyWindow(int windowID){
		if(GUI.Button(new Rect(10,20,100,20),"Hello World"))
			print("Got a click"+windowID);
		GUI.BringWindowToBack (0);//最上面
		GUI.BringWindowToFront (0);//最小面
		GUI.DragWindow (new Rect (0, 0, 10000, 10000));
	}
}
