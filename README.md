# IIS URL Rewrite ServerNameProvider
IIS URL Rewrite variable to display the hosts machine name in the response header.</br></br>
*See "server-name" header below:*</br>
![Header-Pic](https://i.postimg.cc/vTdpC2qb/header-pic.png)

# Usage 
## Installation
Perform the following actions on the IIS server
1. Download [IIS-URL-Rewrite-ServerNameProvider DLL](https://github.com/ThePieMonster/IIS-URL-Rewrite-ServerNameProvider/releases/) to C:\Temp
2. Copy [NETFX-4.8-Tools](https://sourceforge.net/projects/netfx-4-8-tools/files/NETFX-4.8-Tools.zip/download) to C:\Temp
3. Run the following command: `& 'C:\Temp\NETFX-4.8-Tools\gacutil.exe' -i "C:\Temp\IIS-URL-Rewrite-ServerNameProvider.dll"`
4. Run the following command: `& 'C:\Temp\NETFX-4.8-Tools\gacutil.exe' -l`
5. Open IIS -> URL Rewrite (either at server level or site level)
   ![IIS-1.png](https://i.postimg.cc/85r2KfG8/IIS-1.png)
6. Select "View Providers..."
7. Select "Add Provider..."
8. Select the provider from the dropdown and then copy over the name that is listed to the name field
  ![IIS-2.png](https://i.postimg.cc/CxcpzV72/IIS-2.png)
  ![IIS-3.png](https://i.postimg.cc/9fz59NNQ/IIS-3.png)
9. Go back to URL Rewrite and select "Add Rule(s)..."
10. Select a "Blank rule"
  ![IIS-4.png](https://i.postimg.cc/J0N9mwtP/IIS-4.png)
11. Edit the Outbound Rule as shown below<br/>
  ![IIS-5.png](https://i.postimg.cc/c4GkzCxQ/IIS-5.png)
  ![IIS-6.png](https://i.postimg.cc/rsXvvyyD/IIS-6.png)
12. Restart the IIS server


## Compiling
*Note: In order to build the DLL you will need the Key.snk file which can be found [here](https://github.com/ThePieMonster/IIS-URL-Rewrite-ServerNameProvider-Key)*</br>

1. Clone the repository to your local disk
2. Add the Key.snk file to the repository
3. Open solution in Visual Studio 2017 or greater
4. Simply select Build>Build Solution from the top menu
