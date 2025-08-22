# ToggleProcessSuspend

Originally thrown together for [Voices of the Void](https://mrdrnose.itch.io/votv), since it doesn't allow you to pause during intense moments.

Paired with [AutoHotKey](https://www.autohotkey.com/download/ahk-v2.exe), it's a great way to pause and unpause a game or any other process that you know the name of.

Example AHK Script, assuming you place this executable in the same directory:
```
#Requires AutoHotkey v2.0

F1::RunWait("ToggleProcessSuspend.exe VotV-Win64-Shipping", A_WorkingDir, "Hide")
```

Download latest compiled exe [here.](https://github.com/Shaosil/ToggleProcessSuspend/releases/latest/download/ToggleProcessSuspend.exe)
