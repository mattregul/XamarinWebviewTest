using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebviewTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            var htmlSource = new HtmlWebViewSource();

            // CSS Rotating Icon sample from https://stackoverflow.com/questions/6410730/how-to-do-a-webkit-css-endless-rotation-animation/6410923#6410923
            htmlSource.Html = "<!DOCTYPE html><html><head><style>body{background-color:#EEE8AA;}        #test {            width: 11px;            height: 14px;            background: url('data:image/gif;base64,R0lGOD lhCwAOAMQfAP////7+/vj4+Hh4eHd3d/v7+/Dw8HV1dfLy8ubm5vX19e3t7fr 6+nl5edra2nZ2dnx8fMHBwYODg/b29np6eujo6JGRkeHh4eTk5LCwsN3d3dfX 13Jycp2dnevr6////yH5BAEAAB8ALAAAAAALAA4AAAVq4NFw1DNAX/o9imAsB tKpxKRd1+YEWUoIiUoiEWEAApIDMLGoRCyWiKThenkwDgeGMiggDLEXQkDoTh CKNLpQDgjeAsY7MHgECgx8YR8oHwNHfwADBACGh4EDA4iGAYAEBAcQIg0Dk gcEIQA7');        }        @-webkit-keyframes rotating {            from{                -webkit-transform: rotate(0deg);            }            to{                -webkit-transform: rotate(360deg);            }       }        .rotating {            -webkit-animation: rotating 2s linear infinite;        }    </style></head><body>    <div id='test' class='rotating'></div></body></html>";
            
            Browser.Source = htmlSource;

        }
    }
}
