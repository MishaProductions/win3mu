/*
Win3mu - Windows 3 Emulator
Copyright (C) 2017 Topten Software.

Win3mu is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Win3mu is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Win3mu.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Sharp86;

namespace Win3muCore
{
    [Module("SHELL", @"C:\WINDOWS\SYSTEM\SHELL.DLL")]
    public class Shell : Module32
    {
        //0021 - ABOUTDLGPROC - 0021
        //0022 - EXTRACTICON - 0022
        //0015 - FINDEXECUTABLE - 0015
        //0009 - DRAGACCEPTFILES - 0009
        [EntryPoint(0x009)]
        public void DragAcceptFiles(HWND ptr, bool accept)
        {
            DragAcceptFiles(ptr.value, accept);
        }
        [DllImport("shell32.dll")]
        private static extern void DragAcceptFiles(IntPtr hwnd, bool accept);
        //0001 - REGOPENKEY - 0001
        //0002 - REGCREATEKEY - 0002
        //0064 - HERETHARBETYGARS - 0064
        //0026 - FINDENVIRONMENTSTRING - 0026
        //0004 - REGDELETEKEY - 0004
        //0007 - REGENUMKEY - 0007
        //0025 - DOENVIRONMENTSUBST - 0025
        //0014 - SHELLEXECUTE - 0014
        //0065 - FINDEXEDLGPROC - 0065
        //000B - DRAGQUERYFILE - 000B
        //000D - DRAGQUERYPOINT - 000D
        //0005 - REGSETVALUE - 0005
        //0027 - INTERNALEXTRACTICON - 0027
        //0016 - SHELLABOUT - 0016
        //0006 - REGQUERYVALUE - 0006
        //0020 - WCI - 0020
        //0066 - REGISTERSHELLHOOK - 0066
        //0024 - EXTRACTASSOCIATEDICON - 0024
        //000C - DRAGFINISH - 000C
        //0067 - SHELLHOOKPROC - 0067
        //0003 - REGCLOSEKEY - 0003
        //0008 - WEP - 0008
    }
}
