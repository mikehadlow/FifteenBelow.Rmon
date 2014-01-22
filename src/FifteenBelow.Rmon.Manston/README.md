==Manston

This is the HTML GUI

To start:
1. Open a console in the root folder of this project <Rmon root>\src\FifteenBelow.Rmon.Manston
2. >start nginx
3. >tasklist /fi "imagename eq nginx.exe"

	Image Name                     PID Session Name        Session#    Mem Usage
	========================= ======== ================ =========== ============
	nginx.exe                     1580 Console                    1      5,852 K
	nginx.exe                     5828 Console                    1      6,200 K

4. Navigate to http://localhost:8008

To reload conf/nginx.conf
1. >nginx -s reload