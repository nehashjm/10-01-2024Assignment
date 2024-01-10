1 Create the project in vscode 
2 check if the project is execueting and running in vs code console upload to github
3 open Jenkins 
4 create new item -> name -> freestyle -> ok -> description -> gthublink ->
5 add * * * * * in PollSCM
6 cd $WORKSPACE dotnet build dotnet run
7 update the changes in project and push code in github -> git add . git commit -m "changes" git push
8 see the changes by refreshing the jenkins wait for minute to update check the status Started by an SCM change
