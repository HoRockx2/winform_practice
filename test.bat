@echo off
echo hello

set /p "id=Enter ID: "

echo You said %id%

curl.exe -H "Accept: application/vnd.github+json" -H "Authorization: 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" https://api.github.com/repos/HoRockx2/winform_practice/commits

pause