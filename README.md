# PPF-PRECUT-Decoding-GRAPHTEC HPGL

Program Description
The PRECUT Pattern Extraction Program is a powerful tool designed to extract patterns from the PRECUT program. It allows users to retrieve and copy patterns from the PRECUT program, enabling further analysis and utilization of the extracted patterns.

This program provides a straightforward and efficient way to extract patterns without requiring the ability to save files directly from the PRECUT program. It overcomes limitations by directly accessing the program's memory to retrieve the patterns, ensuring a seamless extraction process.

User Instructions

1.  Open the PRECUT program from which you want to decode data.
2.  Save the data file in the desired format, such as pcapng, using the respective program (e.g., Wireshark).
3.  Launch the PRECUT Decoding Program.
4.  Click the "Select File" button to choose the file you want to decode.
5.  Once the file is selected, the program will decode and convert the data into HPGL code.
6.  The decoded and converted HPGL code will be displayed in the "HPGL Code" textbox.

7.  You can now copy the extracted HPGL code and use it with your plotter printer. 
    Simply paste the code into a compatible software or tool that supports HPGL, such as CorelDRAW or Inkscape.
    
8.  The extracted patterns are also saved as files in the following directory: "bin\Debug\net6.0-windows". 
    You can access this directory to retrieve the saved files for further editing or archival purposes.

Compatibility
The PRECUT Pattern Extraction Program has been extensively tested and verified to work seamlessly with Graphtec FC8000 and FC9000 cutting plotters. These models have been specifically tested for compatibility, ensuring accurate pattern extraction and reliable performance.

Please note that this program has not been tested with other cutting plotter models. Compatibility with other models may vary, and it is recommended to perform testing before using the program with different machines.

Additional Instructions (Continued)

To capture date packages in Wireshark, you need to download and install Wireshark from the official website: https://www.wireshark.org/download.html. During the installation process, make sure to select "USBPCAP" as an additional component.
After the installation, restart your computer to apply the changes. Then, open Wireshark and go to the "Capture" tab at the bottom. Click on "Options" to access the settings.
In the Capture Options dialog, check the following options: "Capture from newly connected devices" and "Inject already connected devices descriptors into capture data". Additionally, select "USB Printing Support". Click "Save" to apply the settings.
Now, click on "USBPcap1" in the interface list to start capturing packets. At this point, you can initiate the cutting process from the PRE-CUT program (Note: You don't need to insert actual film into the cutting machine for this step).
Once the PRE-CUT program finishes sending commands, click on the "Stop capturing packets" button (the square-shaped button with a red color) in Wireshark.
To save the captured packets, go to "File" > "Save As..." and choose a destination and filename for the saved file.
Open the Enigma Patterns program and import the saved file from Wireshark.
Click on the "Convert PLT File" button in the Enigma Patterns program.
You can now open the generated PLT file with a compatible HPGL viewer or editor, such as CorelDRAW or Inkscape, to further manipulate or view the HPGL patterns.
