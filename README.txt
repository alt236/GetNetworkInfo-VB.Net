Description

This application will collect information about the network adapters of a Windows based (XP+) computer. It is similar to running "ifconfig /all" but:

* It will work in most cases where "ifconfig" is blocked by your administrator.
* You can use it to remotely get information from a remote computer (via WINS, if you have the appropriate access rights).
* If you are testing the local computer it will retrieve its external/public IP address and hostname (great for fixing DHCP misconfigurations or registration errors and fining out if a PC is using a "floating/temporary" address instead of the one it should be assigned.
* It will create a text file with the results.

Notes

* In the hostname field you can enter the hostname of any windows (XP+) machine for which you have administrative access and the application will try to retrieve the network information.
* If the "Save to file" option is checked, a file containing the extracted information will be created in the application's folder. Use the "Open folder" button to go there.
* The filename format is "hostname_YearMonthDayHourMinuteSecond+Offset.txt" (s5140_20110114183732+00.txt for example).
* Getting the external IP/ Hostname only works if you are getting the information of the computer you are running the application from.

Changelog

* v0.0.0.1: First public release
* v0.0.0.2: Added getting the external IP/ Hostname


