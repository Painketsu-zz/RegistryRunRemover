# RegistryRunRemover
Remove any key from Win+R registry, this program is meant to be used along with https://github.com/Painketsu/RegistryRunAdder

It wont ever remove any important registry keys in case of error, only Win+R keys but still use with caution.

How to use:

1. Run the .bat as admin in the same folder as RegistryRunRemove.exe is going to be
2. Set RegistryRunRemover.exe to always run as admin from right click -> compatibility -> check "Always run as admin"
2. Win+R remove keyName

This removes the key in: HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\[keyName].exe

Example:

Adding game.exe to run.

Win+R -> add "C:/Desktop/GAEM.exe" game
  //game key is added with a mistake
Win+R -> remove game
  //game key is removed from registry
Win+R -> add "C:/Desktop/game.exe" game
