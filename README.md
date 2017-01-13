# ASPNetCoreRedis
ASP.NET Core website with Redis caching

# Install REDIS

## Helpful links

* https://chocolatey.org/
* https://chocolatey.org/packages/redis-64/

## Install procedure
```bash
? @powershell -NoProfile -ExecutionPolicy Bypass 
    -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" 
    && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"
```

```
Mode                LastWriteTime         Length Name
----                -------------         ------ ----
d-----       13/01/2017      9:05                chocInstall
Getting latest version of the Chocolatey package for download.
Getting Chocolatey from https://chocolatey.org/api/v2/package/chocolatey/0.10.3.

                                                                                                                                                                                                            Downloading 7-Zip commandline tool prior to extraction.
Extracting C:\Users\GEERTV~1\AppData\Local\Temp\chocolatey\chocInstall\chocolatey.zip to C:\Users\GEERTV~1\AppData\Local\Temp\chocolatey\chocInstall...
Installing chocolatey on this machine
Creating ChocolateyInstall as an environment variable (targeting 'Machine')
  Setting ChocolateyInstall to 'C:\ProgramData\chocolatey'
WARNING: It's very likely you will need to close and reopen your shell
  before you can use choco.
Restricting write permissions to Administrators
We are setting up the Chocolatey package repository.
The packages themselves go to 'C:\ProgramData\chocolatey\lib'
  (i.e. C:\ProgramData\chocolatey\lib\yourPackageName).
A shim file for the command line goes to 'C:\ProgramData\chocolatey\bin'
  and points to an executable in 'C:\ProgramData\chocolatey\lib\yourPackageName'.

Creating Chocolatey folders if they do not already exist.

WARNING: You can safely ignore errors related to missing log files when
  upgrading from a version of Chocolatey less than 0.9.9.
  'Batch file could not be found' is also safe to ignore.
  'The system cannot find the file specified' - also safe.
chocolatey.nupkg file not installed in lib.
 Attempting to locate it from bootstrapper.
PATH environment variable does not have C:\ProgramData\chocolatey\bin in it. Adding...
WARNING: Not setting tab completion: Profile file does not exist at 'C:\Users\Geert Van Huychem\Documents\WindowsPowerShell\Microsoft.PowerShell_profile.ps1'.
Chocolatey (choco.exe) is now ready.
You can call choco from anywhere, command line or powershell by typing choco.
Run choco /? for a list of functions.
You may need to shut down and restart powershell and/or consoles
 first prior to using choco.
Ensuring chocolatey commands are on the path
Ensuring chocolatey.nupkg is in the lib folder
```

```bash
? choco upgrade chocolatey
```

```
Chocolatey v0.10.3
Upgrading the following packages:
chocolatey
By upgrading you accept licenses for the packages.
chocolatey v0.10.3 is the latest version available based on your source(s).

Chocolatey upgraded 0/1 packages. 0 packages failed.
 See the log for details (C:\ProgramData\chocolatey\logs\chocolatey.log).
```

```bash
? choco install redis-64
```

```
Chocolatey v0.10.3
Installing the following packages:
redis-64
By installing you accept licenses for the packages.

redis-64 v3.0.503 [Approved]
redis-64 package files install completed. Performing other installation steps.
 ShimGen has successfully created a shim for redis-benchmark.exe
 ShimGen has successfully created a shim for redis-check-aof.exe
 ShimGen has successfully created a shim for redis-check-dump.exe
 ShimGen has successfully created a shim for redis-cli.exe
 ShimGen has successfully created a shim for redis-server.exe
 The install of redis-64 was successful.
  Software install location not explicitly set, could be in package or
  default install location if installer.

Chocolatey installed 1/1 packages. 0 packages failed.
 See the log for details (C:\ProgramData\chocolatey\logs\chocolatey.log).
```

 ```bash
? cd C:\ProgramData\chocolatey\lib\redis-64
```

```bash
? .\redis-server.exe
```

```
[384] 13 Jan 09:11:07.252 # Warning: no config file specified, using the default config. In order to specify a config file use .\redis-server.exe /path/to/redis.conf
                _._
           _.-``__ ''-._
      _.-``    `.  `_.  ''-._           Redis 3.0.503 (00000000/0) 64 bit
  .-`` .-```.  ```\/    _.,_ ''-._
 (    '      ,       .-`  | `,    )     Running in standalone mode
 |`-._`-...-` __...-.``-._|'` _.-'|     Port: 6379
 |    `-._   `._    /     _.-'    |     PID: 384
  `-._    `-._  `-./  _.-'    _.-'
 |`-._`-._    `-.__.-'    _.-'_.-'|
 |    `-._`-._        _.-'_.-'    |           http://redis.io
  `-._    `-._`-.__.-'_.-'    _.-'
 |`-._`-._    `-.__.-'    _.-'_.-'|
 |    `-._`-._        _.-'_.-'    |
  `-._    `-._`-.__.-'_.-'    _.-'
      `-._    `-.__.-'    _.-'
          `-._        _.-'
              `-.__.-'

[384] 13 Jan 09:11:07.256 # Server started, Redis version 3.0.503
[384] 13 Jan 09:11:07.256 * The server is now ready to accept connections on port 6379
```