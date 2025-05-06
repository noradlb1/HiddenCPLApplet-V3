@echo off
REM — تعيين مسار ملف CPL
set "CPLPath=C:\Users\MONSTERC DEFENDER\Desktop\CPLApplet.cpl"

REM — التحقق من وجود الملف
if exist "%CPLPath%" (
    echo الملف موجود. جاري التشغيل...
    start "" control "%CPLPath%"
) else (
    echo الملف غير موجود: "%CPLPath%"
    pause
)
