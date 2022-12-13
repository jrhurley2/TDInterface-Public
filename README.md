# TDInterface-Public

This app was inspired by Steve over at https://largecapdaytrader.com/   If you are tired of losing money and want to learn to read price action, go check it out.

Windows Form application that uses TD Ameritrade Apis

Register for a developer account at:
TD Ameritrade for developer | APIs

Once you have an account, login in and Register an app.  *** Important   the callback Url must be http://localhost


TD Ameritrade for developer | Add App


Once approved goto:  TD Ameritrade for developer | My Apps
Click on your newly created app and copy the ConsumerKey.  This key will be used when you start up the program to link it to your TD Ameritrade Registration.


Start TdInterface.exe

The first time it will prompt you for your consumer key.



Then you should get the  TD Ameritrade Login (Enter the account you want to trade under, not a linked account):





If you have multi factor auth turned on it should prompt you for a code exchange.

You should be presented with the screen below.  Where the blue lines are should be your name.  Click Allow.




Enter your risk and a symbol.
For market orders just enter the stop and click Buy or Sell Mrk
For Limit orders enter Stop and Limit  and click Buy or Sell Lmt

A OCO order will be created with the calculated number of shares with a stop at what was specified and a limit order for 1/4 at 1:1.

After the order is executed the Avg Price and Shares will show up.  
Stop Break even will put your stop back.
The % buttons will close a percentage based on the shares still outstanding.



![image](https://user-images.githubusercontent.com/13562737/175017401-c904ddd6-ceae-4d2f-b2d5-3fbdb0df32a9.png)
