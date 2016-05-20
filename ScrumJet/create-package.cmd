rmdir package /s /q
mkdir package

xcopy /I /Y *.cshtml package
xcopy /I /Y *.dll package
xcopy /I /Y *.exe package
xcopy /I /Y *.js package
xcopy /I /Y *.json package
xcopy /I /Y *.css package

del package\*.vshost.exe