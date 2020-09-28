# IIS URL Rewrite ServerNameProvider
IIS URL Rewrite variable to display the hosts machine name in the response header.</br></br>
*See "server-name" header below:*</br>
![Header-Pic](https://i.postimg.cc/vTdpC2qb/header-pic.png)

# Usage 
## Installation
Perform the following actions on the IIS server
<ol>
  <li>Download [IIS-URL-Rewrite-ServerNameProvider DLL](https://github.com/ThePieMonster/IIS-URL-Rewrite-ServerNameProvider/releases/) to C:\Temp</li>
  
  <li>Copy NETFX-4.8-Tools to C:\Temp</li>
 
  <li>& 'C:\Temp\NETFX-4.8-Tools\gacutil.exe' -i "C:\Temp\IIS-URL-Rewrite-ServerNameProvider.dll"</li>
  
  <li>& 'C:\Temp\NETFX-4.8-Tools\gacutil.exe' -l</li>
  
  <li>Open IIS -> URL Rewrite (either at server level or site level)</li>
    
  [![IIS-1.png](https://i.postimg.cc/85r2KfG8/IIS-1.png)](https://postimg.cc/k6qYD4Dw)
  
  <li>Select "View Providers..."</li>
  
  <li>Select "Add Provider..."</li>
  
  <li>Select the provider from the dropdown and then copy over the name that is listed to the name field</li>
  
  [![IIS-2.png](https://i.postimg.cc/CxcpzV72/IIS-2.png)](https://postimg.cc/WdqHHCQm)
  
  [![IIS-3.png](https://i.postimg.cc/9fz59NNQ/IIS-3.png)](https://postimg.cc/qtf5VQTP)
  
  <li>Go back to URL Rewrite and select "Add Rule(s)..."</li>
  
  <li>Select a "Blank rule"</li>
  
  [![IIS-4.png](https://i.postimg.cc/J0N9mwtP/IIS-4.png)](https://postimg.cc/9wfxtnd7)
  
  <li>Edit the Outbound Rule as shown below</li>
  
  [![IIS-5.png](https://i.postimg.cc/rpb6NCvC/IIS-5.png)](https://postimg.cc/R3cbMfCN)
  
  [![IIS-6.png](https://i.postimg.cc/rsXvvyyD/IIS-6.png)](https://postimg.cc/nj2RmJDx)
  
  <li>Restart the IIS server</li>
</ol>


## Compiling
*Note: In order to build the DLL you will need the Key.snk file which can be found [here](https://github.com/ThePieMonster/IIS-URL-Rewrite-ServerNameProvider-Key)*</br>
<ol>
  <li>Clone the repository to your local disk</li>
  <li>Add the Key.snk file to the repository</li>
  <li>Open solution in Visual Studio 2017 or greater</li>
  <li>Simply select Build>Build Solution from the top menu</li>
  <li>See Installation section of read me</li>
</ol>
