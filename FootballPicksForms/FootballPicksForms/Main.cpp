

#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <algorithm>
#include <iomanip>
#include <sstream>

#include "Main.h"
#include "FootballPicks.h"

using namespace System;
using namespace System::Windows::Forms;

[STAThread]//leave this as is
void main(array<String^>^ args) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	FootballPicksForms::Main form;
	Application::Run(%form);
}