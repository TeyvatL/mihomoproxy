
/* Original script by NicknameGG, modified for Grasscutter by contributors. */
import System;
import System.Windows.Forms;
import Fiddler;
import System.Text.RegularExpressions;

class Handlers
{
    static function OnBeforeRequest(oS: Session) {
        if(oS.host.EndsWith(".yuanshen.com") || oS.host.EndsWith(".hoyoverse.com") || oS.host.EndsWith(".mihoyo.com")) {
            oS.host = "127.0.0.1"; //这个可以换成其他ip来链接别人的服务器
        }
    }
};
