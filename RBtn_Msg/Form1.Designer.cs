namespace RBtn_Msg
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gpOption1 = new System.Windows.Forms.GroupBox();
            this.rbYesNo = new System.Windows.Forms.RadioButton();
            this.rbOkCancel = new System.Windows.Forms.RadioButton();
            this.rbOk = new System.Windows.Forms.RadioButton();
            this.gpOption2 = new System.Windows.Forms.GroupBox();
            this.rbQuestion = new System.Windows.Forms.RadioButton();
            this.rbInformation = new System.Windows.Forms.RadioButton();
            this.rbError = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.gpOption1.SuspendLayout();
            this.gpOption2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpOption1
            // 
            this.gpOption1.Controls.Add(this.rbYesNo);
            this.gpOption1.Controls.Add(this.rbOkCancel);
            this.gpOption1.Controls.Add(this.rbOk);
            resources.ApplyResources(this.gpOption1, "gpOption1");
            this.gpOption1.Name = "gpOption1";
            this.gpOption1.TabStop = false;
            // 
            // rbYesNo
            // 
            resources.ApplyResources(this.rbYesNo, "rbYesNo");
            this.rbYesNo.Name = "rbYesNo";
            this.rbYesNo.TabStop = true;
            this.rbYesNo.UseVisualStyleBackColor = true;
            // 
            // rbOkCancel
            // 
            resources.ApplyResources(this.rbOkCancel, "rbOkCancel");
            this.rbOkCancel.Name = "rbOkCancel";
            this.rbOkCancel.TabStop = true;
            this.rbOkCancel.UseVisualStyleBackColor = true;
            // 
            // rbOk
            // 
            resources.ApplyResources(this.rbOk, "rbOk");
            this.rbOk.Name = "rbOk";
            this.rbOk.TabStop = true;
            this.rbOk.UseVisualStyleBackColor = true;
            // 
            // gpOption2
            // 
            this.gpOption2.Controls.Add(this.rbQuestion);
            this.gpOption2.Controls.Add(this.rbInformation);
            this.gpOption2.Controls.Add(this.rbError);
            resources.ApplyResources(this.gpOption2, "gpOption2");
            this.gpOption2.Name = "gpOption2";
            this.gpOption2.TabStop = false;
            // 
            // rbQuestion
            // 
            resources.ApplyResources(this.rbQuestion, "rbQuestion");
            this.rbQuestion.Name = "rbQuestion";
            this.rbQuestion.TabStop = true;
            this.rbQuestion.UseVisualStyleBackColor = true;
            // 
            // rbInformation
            // 
            resources.ApplyResources(this.rbInformation, "rbInformation");
            this.rbInformation.Name = "rbInformation";
            this.rbInformation.TabStop = true;
            this.rbInformation.UseVisualStyleBackColor = true;
            // 
            // rbError
            // 
            resources.ApplyResources(this.rbError, "rbError");
            this.rbError.Name = "rbError";
            this.rbError.TabStop = true;
            this.rbError.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            resources.ApplyResources(this.btnShow, "btnShow");
            this.btnShow.Name = "btnShow";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.gpOption2);
            this.Controls.Add(this.gpOption1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.gpOption1.ResumeLayout(false);
            this.gpOption2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpOption1;
        private System.Windows.Forms.RadioButton rbYesNo;
        private System.Windows.Forms.RadioButton rbOkCancel;
        private System.Windows.Forms.RadioButton rbOk;
        private System.Windows.Forms.GroupBox gpOption2;
        private System.Windows.Forms.RadioButton rbQuestion;
        private System.Windows.Forms.RadioButton rbInformation;
        private System.Windows.Forms.RadioButton rbError;
        private System.Windows.Forms.Button btnShow;
    }
}

