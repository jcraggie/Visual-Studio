#pragma once

namespace FootballPicksForms
{

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Main
	/// </summary>
	public ref class Main : public System::Windows::Forms::Form
	{
	public:
		Main(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Main()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  exit_btn;
	private: System::Windows::Forms::MenuStrip^  menuStrip1;
	private: System::Windows::Forms::ToolStripMenuItem^  fileToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  exitToolStripMenuItem;
	private: System::Windows::Forms::TextBox^  output_txt;
	private: System::Windows::Forms::Button^  run_loop_btn;


	protected:

	protected:




	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->exit_btn = (gcnew System::Windows::Forms::Button());
			this->menuStrip1 = (gcnew System::Windows::Forms::MenuStrip());
			this->fileToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->exitToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->output_txt = (gcnew System::Windows::Forms::TextBox());
			this->run_loop_btn = (gcnew System::Windows::Forms::Button());
			this->menuStrip1->SuspendLayout();
			this->SuspendLayout();
			// 
			// exit_btn
			// 
			this->exit_btn->BackgroundImageLayout = System::Windows::Forms::ImageLayout::None;
			this->exit_btn->Location = System::Drawing::Point(1148, 710);
			this->exit_btn->Name = L"exit_btn";
			this->exit_btn->Size = System::Drawing::Size(75, 23);
			this->exit_btn->TabIndex = 0;
			this->exit_btn->Text = L"Exit";
			this->exit_btn->UseVisualStyleBackColor = true;
			this->exit_btn->Click += gcnew System::EventHandler(this, &Main::exit_btn_Click);
			// 
			// menuStrip1
			// 
			this->menuStrip1->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(1) { this->fileToolStripMenuItem });
			this->menuStrip1->Location = System::Drawing::Point(0, 0);
			this->menuStrip1->Name = L"menuStrip1";
			this->menuStrip1->Size = System::Drawing::Size(1235, 24);
			this->menuStrip1->TabIndex = 1;
			this->menuStrip1->Text = L"menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this->fileToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(1) { this->exitToolStripMenuItem });
			this->fileToolStripMenuItem->Name = L"fileToolStripMenuItem";
			this->fileToolStripMenuItem->Size = System::Drawing::Size(37, 20);
			this->fileToolStripMenuItem->Text = L"File";
			// 
			// exitToolStripMenuItem
			// 
			this->exitToolStripMenuItem->Name = L"exitToolStripMenuItem";
			this->exitToolStripMenuItem->Size = System::Drawing::Size(92, 22);
			this->exitToolStripMenuItem->Text = L"Exit";
			this->exitToolStripMenuItem->Click += gcnew System::EventHandler(this, &Main::exitToolStripMenuItem_Click);
			// 
			// output_txt
			// 
			this->output_txt->Location = System::Drawing::Point(599, 57);
			this->output_txt->Multiline = true;
			this->output_txt->Name = L"output_txt";
			this->output_txt->Size = System::Drawing::Size(623, 647);
			this->output_txt->TabIndex = 2;
			// 
			// run_loop_btn
			// 
			this->run_loop_btn->Location = System::Drawing::Point(348, 177);
			this->run_loop_btn->Name = L"run_loop_btn";
			this->run_loop_btn->Size = System::Drawing::Size(205, 78);
			this->run_loop_btn->TabIndex = 3;
			this->run_loop_btn->Text = L"Run Loop";
			this->run_loop_btn->UseVisualStyleBackColor = true;
			this->run_loop_btn->Click += gcnew System::EventHandler(this, &Main::button1_Click);
			// 
			// Main
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1235, 828);
			this->Controls->Add(this->run_loop_btn);
			this->Controls->Add(this->output_txt);
			this->Controls->Add(this->exit_btn);
			this->Controls->Add(this->menuStrip1);
			this->MainMenuStrip = this->menuStrip1;
			this->Name = L"Main";
			this->Text = L"Main";
			this->menuStrip1->ResumeLayout(false);
			this->menuStrip1->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	private: System::Void exit_btn_Click(System::Object^  sender, System::EventArgs^  e)
	{
		Application::Exit();
	}
	private: System::Void exitToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e)
	{
		Application::Exit();
	}
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e)
	{
		
		int counter = 0;
		for (counter = 0; counter < 10; ++counter)
		{
			output_txt->Text = output_txt->Text + counter + "\r\n";
		}
	}
	};
}
