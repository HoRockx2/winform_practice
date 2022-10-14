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
    - command list 에서 enter key 에 대한 처리. detail popup 보여주면 좋을 듯 !!! 이거 꼭 ㅋㅋㅋ [done] 

- [22.05.03]
    -  Desc 에 대해서도 검색을 가능하게 하고, priority 에 따라 sort 하고 그 결과를 보여주도록 하면 좋을 듯
    -  main form 가 foreground 이면서 그런데 포커스가 검색창 말고 다른곳, detailpopup button 이라던지, 가 있으면 hot key 누를 시 검색창에 포커스가 안감

- [22.05.18]
    - 검색창에 p[ 이렇게 입력하니 에러 발생함

- [22.10.13]
    - 디테일 페이지에서 단축기 기능 개발 및 
    - focus index [done]

- [22.10.14]
    - import 기능 추가하기
