using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicRest
{
    public partial class Form1 : Form
    {
        List<RestInfo> _arrListRestInfo = new List<RestInfo>();
        RestInfo _curRestInfo;
        BindingList<KeyInfo> _arrListKeys = new BindingList<KeyInfo>();

        public Form1()
        {
            InitializeComponent();
            InitVaribles();
        }

        private void InitVaribles()
        {
            comboNewMethod.Items.Add(RequestFunc.DEF_METHOD_GET);
            comboNewMethod.Items.Add(RequestFunc.DEF_METHOD_POST);
            comboNewMethod.SelectedIndex = 0;

            comboMethod.Items.Add(RequestFunc.DEF_METHOD_GET);
            comboMethod.Items.Add(RequestFunc.DEF_METHOD_POST);
            comboMethod.SelectedIndex = 0;

            dataGridViewParam.DataSource = _arrListKeys;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string path = textboxUrl.Text;
            string method = comboMethod.SelectedItem.ToString();

            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Can't be empty");
                return;
            }
            
            if (_curRestInfo == null)
            {
                _curRestInfo = new RestInfo();
            }

            // send request
            _curRestInfo.Path = path;
            _curRestInfo.SetRequestMethod(method);
            string param = KeyInfo.GetJson(_arrListKeys);
            _curRestInfo.Param = param;
                       

            string result = RequestFunc.GetInstance().SendRequest(_curRestInfo);            

            // set result
            textBoxResult.Text = result;
            _curRestInfo.Result = result;
        }

        private void Test()
        {
            RestInfo restInfo = new RestInfo();
            restInfo.Param = "access_token=6310970b75cb92744607755654b774db3e7b9bac";
            restInfo.Path = "https://api.particle.io/v1/devices";
            restInfo.RequestMethod = DEF_REQUEST_METHOD.REQUEST_POST;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string path = textBoxNewUrl.Text;
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Can't be Empty!");
                return;
            }

            // add
            RestInfo restInfo = new RestInfo();
            restInfo.Path = path;
            string method = comboNewMethod.SelectedItem.ToString();
            restInfo.SetRequestMethod(method);

            _arrListRestInfo.Add(restInfo);

            // init textbox
            MessageBox.Show("Url was added!");
            textBoxNewUrl.Text = "";

            // refresh
            refreshUrls();
        }

        private void refreshUrls()
        {
            // select-comobo
            comboSelectUrl.Items.Clear();
            foreach (RestInfo restInfo in _arrListRestInfo)
            {
                comboSelectUrl.Items.Add(restInfo.Path);
            }
            comboSelectUrl.SelectedIndex = comboSelectUrl.Items.Count - 1;

            // input-combo
            comboParamUrl.Items.Clear();
            foreach (RestInfo restInfo in _arrListRestInfo)
            {
                comboParamUrl.Items.Add(restInfo.Path);
            }

        }

        private void comboSelectUrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboSelectUrl.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            _curRestInfo = _arrListRestInfo[index];
            if (_curRestInfo == null)
                return;

            // set by selected url
            textboxUrl.Text = _curRestInfo.Path;
            if (_curRestInfo.RequestMethod == DEF_REQUEST_METHOD.REQUEST_GET)
            {
                comboMethod.SelectedItem = RequestFunc.DEF_METHOD_GET;
            } else
            {
                comboMethod.SelectedItem = RequestFunc.DEF_METHOD_POST;
            }

            // set param
            BindingList<KeyInfo> arrListKeys = KeyInfo.GetBindingList(_curRestInfo.Param);
            _arrListKeys.Clear();
            if (arrListKeys != null)
            {
                foreach(KeyInfo keyInfo in arrListKeys)
                {
                    _arrListKeys.Add(keyInfo);
                }
            }

            // set result
            textBoxResult.Text = _curRestInfo.Result;
        }
    }
}
