/* The Nim game written by Volynsky Alex ,2005.
 * 
 * The code demonstrates the work of the standard widgets in C#.
 * The following code illustrates the process of dynamic creation and initialization 
 * of these widgets(for example buttons,ComboBoxes, image, etc.)
 * 
 * This is a source code, that you can modify to suite your needs.
 * People will be able to improve/modify the source code to accomplish tasks/needs 
 * of their own.(The basic idea behind almost all open source,of course).
 * I know that some people have written Nim-like code and functions for their own project,
 * I'm hoping that we can stop re-inventing wheels.
 */

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace prjNimGame
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem mnuExit;
		private System.Windows.Forms.MenuItem mnuNewGame;
		private System.Windows.Forms.MenuItem mnuPlayComputer;
		private System.Windows.Forms.MenuItem mnuPlayAgain;
		private System.Windows.Forms.MenuItem mnuPlayHuman;
        private IContainer components;
        private bool winBlue;
		private bool winRed;

		private int SumOfImages;

		private bool FlagColor;
		private int num_choos_pens;
		private int index;
		private System.Windows.Forms.Button btnOK;
		private  ComboBox[] cmbbox;         // ComboBox Array
		private PictureBox[][] images;      // PictureBox Jagged Arrays
		private int[] numberLoadImages={0}; // Integers Array
		private int[] BlueRedImages={0};    // Integers Array
        
		  /**************************************************/
		 /* The method creates seven ComboBoxes            */
		/**************************************************/
		void CreateNew_ComboBoxes()
		{
			int i,x=31;
		   	
			// memory allocation and object zeroing
			try
			{
				 cmbbox =  new  ComboBox[7];

				for ( i = 0; i < 7; i++)
				{   
					cmbbox[i] = new ComboBox();
					cmbbox[i].Parent=this;
					cmbbox[i].Width=40;
					cmbbox[i].Location=new Point(x,5);
					x+=107;
					cmbbox[i].ForeColor=Color.Blue;
					cmbbox[i].MaxDropDownItems=30;
					cmbbox[i].Tag=i;
	                cmbbox[i].DropDownStyle=ComboBoxStyle.DropDownList;
					cmbbox[i].Visible=true;
					cmbbox[i].SelectedValueChanged += new System.EventHandler(this.Change_Select_Data_ComboBox);
					
				}

				FlagColor = true;
			}
			catch (System.IndexOutOfRangeException exc)
			{
				MessageBox.Show(exc.Message,"Overloaded");
				return;
			}
				
		}
		
		  /**************************************************/
		 /* The method enters numbers in ComboBoxes        */
		/**************************************************/
		void Fill_ComboBoxes()
		{
			Random rdm; 
			int Number_Members_In_One_Row;

			SumOfImages=0; // sum of all pencils
			for (int i = 0; i < 7; i++)
			{   
				
				rdm = new Random(unchecked((int)DateTime.Now.Ticks));

				// get random number of elements for one heap
				Number_Members_In_One_Row = (rdm.Next(30)+1); 

				SumOfImages+=Number_Members_In_One_Row;

				if(cmbbox[i].Items.Count!=0)
				{
					cmbbox[i].Items.Clear();
				}

				for(int k=1; k<=Number_Members_In_One_Row; k++)
				{
					cmbbox[i].Items.Add(k);
					
				}

                cmbbox[i].Text=Number_Members_In_One_Row.ToString();

				num_choos_pens=0;
				System.Threading.Thread.Sleep(35);
			}

		}
		  /****************************************************/
		 /* The method changes color of pressed button       */
		/****************************************************/
		void ChangeColor_ComboBoxes_Button()
		{
			int i;
			Color clr;

			if(FlagColor)
			{
				clr=Color.Red;
				FlagColor=false;
			}
			else
			{
				clr=Color.Blue;
				FlagColor=true;
			}
			

			this.btnOK.BackColor=clr;

			for ( i = 0; i < 7; i++)
			{
				cmbbox[i].ForeColor=clr;
			}
		}
		
		  /*******************************************************************/
		 /* The method creates a matrix in the size 7 on 30 for the pencils    */
		/*******************************************************************/
		void CreateNew_Images()
		{
			int y;
			int x=0;
			Image image = Image.FromFile("GrayPen.bmp");  
            
			images = new PictureBox[7][];
           
			for(int i=0; i<7; i++,x+=107)
			{
				y=this.Height-(int)(6*(image.Height));
				images[i] = new PictureBox [30];
                
				for(int j=0; j<30; j++)
				{
					images[i][j]= new PictureBox();
					images[i][j].Parent=this;
					images[i][j].Height=15;
					images[i][j].Width=104;
					images[i][j].Anchor=AnchorStyles.Bottom|AnchorStyles.Left;
					images[i][j].Location=new Point(x,y);
					y-=16;

				}
			}			

		}
        
		  /*************************************************************/
		 /* The method fills in a matrix gray pencils                 */
		/*************************************************************/
		void Fill_Images()
		{
			int new_number_elements;
			int old_number_elements;

			Image image = Image.FromFile("GrayPen.bmp"); 
  
			for(int i=0; i<7; i++)
			{
				
				new_number_elements = cmbbox[i].Items.Count;
				old_number_elements=(int)numberLoadImages[i];

				// if you must insert images
				if(old_number_elements < new_number_elements)
				{
					for(int j=old_number_elements; j<new_number_elements; j++)
					{

						images[i][j].Image=image;
						
					}
					numberLoadImages.SetValue(new_number_elements,i);
					
				}
				// if you must remove images
				else if(old_number_elements > new_number_elements)
				{
					PictureBox img = new PictureBox();
					
					for(int j=old_number_elements-1; j>=new_number_elements; j--)
					{

						images[i][j].Image=img.Image; 
					}
					numberLoadImages.SetValue(new_number_elements,i);
				}
				
				
			}

		}

		  /*************************************************************/
		 /* The method creates and initializes the main form          */
		/*************************************************************/
		public Form1()
		{
			///
			// Required for Windows Form Designer support
			//
			InitializeComponent();  // initialize components as menu,button,etc.
			FirstMyInitialize();    // create/initialize two arrays
			CreateNew_ComboBoxes(); // create 7 combo boxes
			Fill_ComboBoxes();      // fill items of created combo boxes
			CreateNew_Images();     // create matrix, size 7x30 
			Fill_Images();          // fill created matrix
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.mnuNewGame = new System.Windows.Forms.MenuItem();
            this.mnuPlayAgain = new System.Windows.Forms.MenuItem();
            this.mnuPlayComputer = new System.Windows.Forms.MenuItem();
            this.mnuPlayHuman = new System.Windows.Forms.MenuItem();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuExit,
            this.mnuNewGame,
            this.mnuPlayAgain});
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 0;
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuNewGame
            // 
            this.mnuNewGame.Index = 1;
            this.mnuNewGame.Text = "New Game";
            this.mnuNewGame.Click += new System.EventHandler(this.mnuNewGame_Click);
            // 
            // mnuPlayAgain
            // 
            this.mnuPlayAgain.Index = 2;
            this.mnuPlayAgain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuPlayComputer,
            this.mnuPlayHuman});
            this.mnuPlayAgain.Text = "Play against...";
            // 
            // mnuPlayComputer
            // 
            this.mnuPlayComputer.Index = 0;
            this.mnuPlayComputer.Text = "Computer";
            this.mnuPlayComputer.Click += new System.EventHandler(this.mnuPlayComputer_Click);
            // 
            // mnuPlayHuman
            // 
            this.mnuPlayHuman.Checked = true;
            this.mnuPlayHuman.Index = 1;
            this.mnuPlayHuman.Text = "Human";
            this.mnuPlayHuman.Click += new System.EventHandler(this.mnuPlayHuman_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOK.BackColor = System.Drawing.Color.Blue;
            this.btnOK.Location = new System.Drawing.Point(323, 75);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(35, 130);
            this.btnOK.TabIndex = 0;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(368, 265);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Nim  Version 1.0  by Volynsky Alex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		  /****************************************************/
		 /* The start point of the program           */
		/****************************************************/
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
        
		  /*************************************************************/
		 /* Event of pressing on item Exit in the toolbar of the menu   */
		/*************************************************************/
		private void mnuExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		  /***************************************************************/
		 /* Event of pressing on item New Game in the toolbar of the menu */
		/***************************************************************/
		private void mnuNewGame_Click(object sender, System.EventArgs e)
		{
			winBlue=true;
			winRed=false;
			UpdateGameWin();

			Fill_ComboBoxes();
			Fill_Images();

			FlagColor=false;
			ChangeColor_ComboBoxes_Button();

			PictureBox emptyIcon = new PictureBox();
			this.btnOK.Image=emptyIcon.Image;

			for(int i=0; i<7; i++ )
				cmbbox[i].Enabled=true;

			btnOK.Focus();
		}
        
		  /********************************************************************/
		 /* Event of pressing on item Play Computer in the toolbar of the menu */
		/********************************************************************/
		private void mnuPlayComputer_Click(object sender, System.EventArgs e)
		{
			mnuPlayComputer.Checked=true;
			mnuPlayHuman.Checked=false;

			if(this.winRed)
			{
				Image icon = Image.FromFile("Computer.ico");
				this.btnOK.Image=icon;

				for(int i=0; i<7; i++ )
					cmbbox[i].Enabled=false;
			}
		}

		  /********************************************************************/
		 /* Event of pressing on item Play Hyman in the toolbar of the menu    */
		/********************************************************************/
		private void mnuPlayHuman_Click(object sender, System.EventArgs e)
		{   
			mnuPlayHuman.Checked=true;
			mnuPlayComputer.Checked=false;	

			PictureBox emptyIcon = new PictureBox();
			this.btnOK.Image=emptyIcon.Image;

			for(int i=0; i<7; i++ )
				cmbbox[i].Enabled=true;
		}

		  /********************************************************************/
		 /* Event of pressing on button                                      */
		/********************************************************************/
		private void btnOK_Click(object sender, System.EventArgs e)
		{
			
			if(this.mnuPlayHuman.Checked) // option 'game with human' is chosen
			{         
				if(num_choos_pens!=0)
				{
					HumanGame();
                    ChangeColor_ComboBoxes_Button();
				}
			}
			// option 'game with computer' is chosen
			else
			{   
				
				if(this.winBlue) // query by human
				{
					if(num_choos_pens!=0) // if human chooses some number of pencils...
					{   
						PreparationNewStep();
						HumanGame();
						PreparationNewStep();
						ChangeColor_ComboBoxes_Button();
					}
					else
						return;
					 
				}
				else // query by computer
				{
						PreparationNewStep();
						ComputerGame();
						PreparationNewStep();
					    ChangeColor_ComboBoxes_Button();
				}
					   			
			}
			
			
		}

		  /*******************************************************/
		 /* The method for creation/initialization two arrays     */
		/*******************************************************/
		private void FirstMyInitialize() 
		{
			BlueRedImages = new int[7];
			numberLoadImages = new int[7];

			for(int i=0; i<7; i++ )
			{
				numberLoadImages.SetValue(0,i);
				BlueRedImages.SetValue(0,i);
			}

			SumOfImages=0;
			winBlue=true;
			winRed=false;
		}
		  /********************************************************************/
		 /* Event of selecting some item in any combobox                     */
		/********************************************************************/
		private void Change_Select_Data_ComboBox(object sender, System.EventArgs e)
		{
			ComboBox cmb= (ComboBox)sender;
			if (cmb.SelectedIndex != -1 )
			{
				num_choos_pens=(int)Convert.ToInt16(cmb.SelectedItem.ToString());
				index=(int)cmb.Tag;

			}
			else
				num_choos_pens=0;
          
		}
		
		  /****************************************************/
		 /* Human's game strategy                            */
		/****************************************************/
		private void HumanGame()
		{
			int newNumElementsInComboBox;

			if(num_choos_pens!=0)
			{   
				int i,j,count;
				
				//Load images from current directory
				Image imageBlue = Image.FromFile("BluePen.bmp"); 
				Image imageRed = Image.FromFile("RedPen.bmp"); 
                
				// save number of the remaining pencils
				SumOfImages = SumOfImages-num_choos_pens; 

				count=num_choos_pens;
				j=((int)numberLoadImages[index]-BlueRedImages[index]-1);
                
				while(count>0)
				{
					cmbbox[index].Items.Remove(cmbbox[index].Items.Count);
					count--;
				}
               
				// Save blue/red items in array images[index][]...
				BlueRedImages[index]=BlueRedImages[index]+ num_choos_pens;

				if(winBlue)
				{	
					for(i=0; i<num_choos_pens; i++,j--)
					{
						images[index][j].Image=imageBlue;
					}
					if(SumOfImages==0)
					{
						switch(MessageBox.Show("New Game?","The game is over.Blue won",MessageBoxButtons.YesNo))
						{
							case DialogResult.Yes: //New Game
								this.winBlue=true;
								this.winRed=false;
								this.UpdateGameWin();
								this.Fill_ComboBoxes();
								this.Fill_Images();
								this.btnOK.Focus();
								FlagColor=false;
								return;
							case DialogResult.No: //Finish Game
								this.Close(); 
								break;
						}
					}

				}
				else
				{
					for(i=0; i<num_choos_pens; i++,j--)
					{
						images[index][j].Image=imageRed;
					}
					if(SumOfImages==0)
					{
						switch(MessageBox.Show("New Game?","The game is over.Red won",MessageBoxButtons.YesNo))
						{
							case DialogResult.Yes: //New Game
								this.winBlue=true;
								this.winRed=false;
								this.UpdateGameWin();
								this.Fill_ComboBoxes();
								this.Fill_Images();
								this.btnOK.Focus();
								FlagColor=false;
								return;
							case DialogResult.No: //Finish Game
								this.Close(); 
								break;
						}
					}
				}
               

				newNumElementsInComboBox=cmbbox[index].Items.Count;
				cmbbox[index].Text=(newNumElementsInComboBox>0)? Convert.ToString(newNumElementsInComboBox):"";
			
			}

			winBlue=!winBlue;
			winRed=!winRed;
			num_choos_pens=0;
			index=-1;
		}
		
		  /*******************************************************/
		 /* Computer's game strategy                            */
		/*******************************************************/	
		private void ComputerGame()
		{ 
			int [] arr = new int[7];

			//Array numbers of "gray" pens in each column
			for(int i=0; i<7; i++ )
			{
				arr[i]=((int)numberLoadImages[i]-BlueRedImages[i]);
			}

			int tryResultElements=-1;
			int numElements;
			int n;

			//////////////////////////////////////////////////////////////////
			// 3 cycles  for find column and number elements                //
			//////////////////////////////////////////////////////////////////
			//for k times
			for(int k=0; k<7 && tryResultElements!=0 ; k++)
			{
				numElements=arr[k];
				
				for (n=1; n<=numElements; n++)
				{   
					     num_choos_pens=n; 
					     index=k;
                    ////////////////////////////////////////////////////
					tryResultElements = numElements-n;
					//for m columns 
					for(int m=0; m<7; m++)
					{
						if(k!=m)
							tryResultElements^=arr[m];
					}
                        
					if(tryResultElements==0)
					{  
						num_choos_pens=n; 
						index=k;
						break;
					}
				}
					
			}

			
			//////////////////////////////////////////////////////////////////
			// from (k+1) column computer must get n elements               //
			//////////////////////////////////////////////////////////////////
			int j;
			int count;

			Image imageRed = Image.FromFile("RedPen.bmp"); 

			SumOfImages = SumOfImages-num_choos_pens;

			count=num_choos_pens;
			j=((int)numberLoadImages[index]-BlueRedImages[index]-1);
                
			while(count>0)
			{
				cmbbox[index].Items.Remove(cmbbox[index].Items.Count);
				count--;
			}
               
			//Save blue/red items in array images[index][]...
			BlueRedImages[index]=BlueRedImages[index]+ num_choos_pens;

			for(int i=0; i<num_choos_pens; i++,j--)
			{
				images[index][j].Image=imageRed;
			}

			if(SumOfImages==0)
			{
				switch(MessageBox.Show("New Game?","The game is over.Red won",MessageBoxButtons.YesNo))
				{
					case DialogResult.Yes: //New Game
						this.winBlue=true;
						this.winRed=false;
						this.UpdateGameWin();
						this.Fill_ComboBoxes();
						this.Fill_Images();
						this.btnOK.Focus();
						this.num_choos_pens=0;
						this.index=-1;
						this.FlagColor=false;
						return;
					case DialogResult.No: //Finish Game
						this.Close(); 
						break;
				}
			}
			
               
			int newNumElementsInComboBox;
			newNumElementsInComboBox=cmbbox[index].Items.Count;
			cmbbox[index].Text=(newNumElementsInComboBox>0)? Convert.ToString(newNumElementsInComboBox):"";
		    
			winBlue=!winBlue;
			winRed=!winRed;
			num_choos_pens=0;
			index=-1;
			 
                       
		}

		/*********************************************************************/
		/* The method updates the matrix of images and also cleans two arrays */
		/*******************************************************************/
		private void UpdateGameWin()
		{
			PictureBox img = new PictureBox();
			Color clr = Color.Blue;

			for(int i=0; i<7; i++ )
			{ 
				
				for(int j=0; j<30;j++)
				{
					images[i][j].Image=img.Image; 
				}

				this.numberLoadImages.SetValue(0,i);
				this.BlueRedImages.SetValue(0,i);
			}
			
		}
        
		/*********************************************************************/
		/* The method make some preparations before a new step              */
		/*******************************************************************/
        private void PreparationNewStep()
        {
			if(winRed) // option 'game with computer' is chosen
			{
				Image icon = Image.FromFile("Computer.ico");
				this.btnOK.Image=icon;

				for(int i=0; i<7; i++ )
					cmbbox[i].Enabled=false;

			}
			else       // option 'game with human' is chosen
			{
			   PictureBox emptyIcon = new PictureBox();
			   this.btnOK.Image=emptyIcon.Image;

				for(int i=0; i<7; i++ )
					cmbbox[i].Enabled=true;
			}

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}



