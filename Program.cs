using System.Diagnostics;
using System.Runtime.InteropServices;

[DllImport("ntdll.dll")]
static extern int NtSuspendProcess(IntPtr processHandle);

[DllImport("ntdll.dll")]
static extern int NtResumeProcess(IntPtr processHandle);

[DllImport("kernel32.dll")]
static extern IntPtr OpenProcess(int access, bool inheritHandle, int processId);

[DllImport("kernel32.dll")]
static extern bool CloseHandle(IntPtr hObject);

// -------------------------------------------------------------------------------------------- \\

if (args.Length == 0) return;
var proc = Process.GetProcessesByName(args[0]).FirstOrDefault();
if (proc == null) return;

IntPtr hProc = OpenProcess(0x0800, false, proc.Id);
if (hProc == IntPtr.Zero) return;

if (proc.Threads.Cast<ProcessThread>().All(t => t.ThreadState == System.Diagnostics.ThreadState.Wait)) NtResumeProcess(hProc);
else NtSuspendProcess(hProc);

CloseHandle(hProc);