# NetMergeExe

![alt text](https://github.com/proxytype/NetMergeExe/blob/master/exeMerge.png)

The attacker possesses the capability to seamlessly merge two distinct executable files within a single application. One of these files operates visibly and legitimately, while the other discreetly runs in the background without any perceptible notice. This tool exhibits versatility through various forms and employs a range of techniques for execution. Despite its complex functionalities, the project maintains simplicity by leveraging the widely accessible and standard .Net compiler, csc.exe.

1. support different .Net versions.
2. generating random names each creation.
3. export files to specific system folders.
4. automatic set files as hidden.
5. easliy configure and updatable.


Main Concept

Read the executable files bytes, compress them with Gzip and convert to base64 string, 
updating the pattern file with the data and compile it as windows application for avoiding the console popup.

Clicking the merge exe will uncompress the files and write them to selected folders as hidden, 
at the end it will execute them.


