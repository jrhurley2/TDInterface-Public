<!-- PROJECT LOGO -->
<br />
<div align="center">

  <a href="https://github.com/jrhurley2/TDInterface-Public">
    <img src="TdInterface/Resources/logo-96.png" alt="Logo" width="180" height="180">
  </a>

<h3 align="center">EZ Trade Manager</h3>

<p align="center">
    <a href="https://github.com/jrhurley2/TDInterface-Public/tags">
        <img alt="GitHub tag" src="https://img.shields.io/github/v/tag/jrhurley2/TDInterface-Public?label=release&sort=semver&style=for-the-badge" /></a>
    <a href="https://github.com/jrhurley2/TDInterface-Public/graphs/commit-activity">
        <img alt="GitHub commit activity" src="https://img.shields.io/github/commit-activity/m/jrhurley2/TDInterface-Public?style=for-the-badge&color=red"/></a>
    <a href="https://github.com/jrhurley2/TDInterface-Public/network/members">
        <img alt="Forks" src="https://img.shields.io/github/forks/jrhurley2/TDInterface-Public.svg?style=for-the-badge" /></a>
    <a href="https://github.com/jrhurley2/TDInterface-Public/stargazers">
        <img alt="Stars" src="https://img.shields.io/github/stars/jrhurley2/TDInterface-Public.svg?style=for-the-badge&color=yellowgreen" /></a>
    <a href="https://github.com/jrhurley2/TDInterface-Public/issues">
        <img alt="Issues" src="https://img.shields.io/github/issues/jrhurley2/TDInterface-Public.svg?style=for-the-badge" /></a>
    <a href="https://github.com/jrhurley2/TDInterface-Public/blob/master/LICENSE.txt">
        <img alt="License" src="https://img.shields.io/github/license/jrhurley2/TDInterface-Public.svg?style=for-the-badge" /></a>
</p>

  <p align="center">
    EZ Trade Manager allows trading with fixed risk on every trade using TD America or TradeStation APIs, and provides easy one click buttons to scale out of trades
    <br />
    <a href="https://github.com/jrhurley2/TDInterface-Public#about-the-project"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/jrhurley2/TDInterface-Public/issues">Report Bug</a>
    ·
    <a href="https://github.com/jrhurley2/TDInterface-Public/issues">Request Feature</a>
  </p>
</div>

<!-- ABOUT THE PROJECT -->
## About The Project
> ⚠️ **TDA is working on their migration with Schwab. At this time you can NOT get an API key. ** ⚠️
> 
>  ℹ️ We will update this page and update the app with any changes required when the migration to Schwab is complete.
>  
> ![image](https://user-images.githubusercontent.com/13562737/212210538-d6736416-90f3-489b-a3ea-5fd055e3c59c.png)


*****


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



## Options Screen

**Trade Shares** - Defaults to trading a straight share quantity, instead of calculations based of risk
**Max Shares** - How many shares to trade, if Trade Shares Enabled
**Max Risk** - Your default Risk, you can change this in the trade window.

**use Bid/Ask Oco Calc** - By default it will use Last on your risk calculation, if this is set it will use the bid or ask, depending on trade direction.

**1st Target Share Precentage** - This is how much it will create the initial 1:1 Limit order for.

**Move Limit On Fill** - This will move your limit order to be the same distance from your fill price as your stop is.  So say that when you place the order the Stop was $100 and the stock was at 100.10, it would have placed your limit at 100.20.  Say it fills for 100.12.  With this enabled, after the fill it would move you 1:1 Limit to 100.24.

**Reduce Stop on Close** -  So when taking profit if you already have a stop order out there,   It will change the stop order to a market/limit order for the amount of shares, and then add a stop back to protect the rest of the trade ( I really should not make this an option and just have it do it.)

**Default Limit Offset** - If you don't have anything in the  limit order box, and you have this set to say .02.  When taking limit orders it will place a limit for the bid/ask + .02.   So if the ask was at 100.10 and you Buy Limit, it will put the limit at 100.12

**Enable Max Loss Limit (R) Value** - to reduce overtrading on a bad day, will disable the trading from the ask if you hit your max R

**Prevent Exceeding Max Loss** - So say your risk is $5, and you are down $12 for the day, it won't let you take anothe trade unless you change your risk to $3

**Adjust Risk Not Exceed Max Loss** - So say your risk is $5, and you are down $12 for the day, it will only use $3 in the trade calculation.

**Min Risk** - So say you are trading and the stock is at $100.05, and you put your stop at 99.99.  Which gives you .06 of risk.  if there is any slippage, and say the stock goes to 100.07 before you hit the button, that will make your risk .08, which is a 33% increase of what you wanted.  If this is set to say .15, it will base all calculations off .15 instead of .06, which would save you from these unwanted side effects

**Send Alt-PrtScr On Open** - This will send the key combo of Alt-PrtScr to the windows OS.   I have SnagIt setup to do screenshots on this key combo.  There is other software out there to do this as well,   but its so you can get a point in time pic of what was going on when you entered.

**Capture Screenshot on Open** - This will capture all monitors in one screenshot and save the files to your Pictures Folder. A new folder per day will be created, with a folder with each ticker traded that day.

**Show PnL** - Shows PnL in the trade window.
