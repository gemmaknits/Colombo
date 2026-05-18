copy source code from server to colombo repo
use claude code and set the folder to the GitHub repo local folder
ask claude to investigate the source code to identify which form uses Syncfusion
ask claude to remove all syncfusion reference and replace with standard windows form control.
If standard windows form control cannot replace syncfusion, then ask claude to suggest what to do

use the following prompt.
"Check the source code to identify all references of Syncfusion.
List the forms and code where syncfusion controls are used.
If the syncfusion controls are removed, analyse and report what will be affected and what is the alternative solution."

