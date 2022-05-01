# REFERENCE
- hotkey, context menu, notify icon, 
	- https://rightnowdo.tistory.com/entry/C-%EC%9D%91%EC%9A%A9-Tray-icon-%EC%9D%91%EC%9A%A9%ED%94%84%EB%A1%9C%EA%B7%B8%EB%9E%A8-%EB%A7%8C%EB%93%A4%EA%B8%B0
- Debug logger
	- https://m.blog.naver.com/PostView.naver?isHttpsRedirect=true&blogId=nateen7248&logNo=220849032455
- Notify icon (Tray icon)
	- https://www.csharpstudy.com/WinForms/WinForms-notifyicon.aspx

- We can find source code of windows dll
    -https://referencesource.microsoft.com/#System.Windows.Forms/winforms/Managed/System/WinForms/Button.cs,cb5c00483936b8f7
    
    
- P-Invokes issue
    - https://docs.microsoft.com/ko-kr/dotnet/fundamentals/code-analysis/quality-rules/ca1401 : issue
    - https://docs.microsoft.com/ko-kr/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers : access modifier

- Known issue
    - Need to handle logic when .dat file doesn't exist

- Making AboutBox
    - https://iamadeveloper.tistory.com/181
    - Get Assembly data...?
        - https://nathondalton.wordpress.com/2016/10/03/use-assembly-title-description-company-copyright-version-in-c/

- basic guide about winform layout
    - https://docs.microsoft.com/ko-kr/dotnet/desktop/winforms/controls/layout?view=netdesktop-6.0

# Issue list
- [22.04.26] 
	- Form 이 Hide 되어있지 않은 상황에서 hot key 를 누를 시 Form 에 포커스가 안가는 현상 [done]
	- Alt key 는 위 메뉴 동작에도 영향을 줘서, 복사 핫키를 Ctrl 로 변경하는게 좋겠음. [done]

- [22.04.27]
	- notification tray double click 시 show [done]

- [22.05.01]
    - command list 에서 enter key 에 대한 처리. detail popup 보여주면 좋을 듯 