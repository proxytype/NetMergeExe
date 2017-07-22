# NetMergeExe

Attacker can merge 2 different executable files, one run as legitimate and another run in the background without any notice,
this tool have many forms and used many techniques, this project it pretty simple and using standard .Net compiler (csc.exe).

1. support different .Net versions.
2. generating random names each creation.
3. export files to specific system folders.
4. automatic set files as hidden.
5. easliy configure and updatable.


Main Concept

Read the executable files bytes, compress them with Gzip and convert to base64 string, 
than updating the pattern file with the data and compile it as windows application for avoiding the console popup.

Clicking the merge exe will uncompress the files and write them to selected folders as hidden, 
at the end it will execute them.
