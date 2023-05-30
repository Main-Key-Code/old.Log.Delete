
namespace old.Log.Delete
{
    partial class MainF
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
            this.btn_CreateLogFile = new System.Windows.Forms.Button();
            this.tBox_Log = new System.Windows.Forms.RichTextBox();
            this.btn_FolderFileList = new System.Windows.Forms.Button();
            this.btn_OpenLogFolder = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DeleteFile = new System.Windows.Forms.Button();
            this.btn_LogTextClear = new System.Windows.Forms.Button();
            this.btn_rangeCreate = new System.Windows.Forms.Button();
            this.tBox_Range = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_RangeDeleteFile = new System.Windows.Forms.Button();
            this.tBox_DeleteRange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CreateLogFile
            // 
            this.btn_CreateLogFile.Location = new System.Drawing.Point(37, 29);
            this.btn_CreateLogFile.Name = "btn_CreateLogFile";
            this.btn_CreateLogFile.Size = new System.Drawing.Size(133, 23);
            this.btn_CreateLogFile.TabIndex = 0;
            this.btn_CreateLogFile.Text = "예제 파일 생성";
            this.btn_CreateLogFile.UseVisualStyleBackColor = true;
            this.btn_CreateLogFile.Click += new System.EventHandler(this.btn_CreateLogFile_Click);
            // 
            // tBox_Log
            // 
            this.tBox_Log.BackColor = System.Drawing.Color.Silver;
            this.tBox_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBox_Log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tBox_Log.Font = new System.Drawing.Font("Arial", 12F);
            this.tBox_Log.ForeColor = System.Drawing.Color.Black;
            this.tBox_Log.Location = new System.Drawing.Point(0, 296);
            this.tBox_Log.Name = "tBox_Log";
            this.tBox_Log.Size = new System.Drawing.Size(800, 266);
            this.tBox_Log.TabIndex = 1;
            this.tBox_Log.Text = "";
            // 
            // btn_FolderFileList
            // 
            this.btn_FolderFileList.Location = new System.Drawing.Point(37, 73);
            this.btn_FolderFileList.Name = "btn_FolderFileList";
            this.btn_FolderFileList.Size = new System.Drawing.Size(133, 23);
            this.btn_FolderFileList.TabIndex = 2;
            this.btn_FolderFileList.Text = "파일 리스트 불러오기";
            this.btn_FolderFileList.UseVisualStyleBackColor = true;
            this.btn_FolderFileList.Click += new System.EventHandler(this.btn_FolderFileList_Click);
            // 
            // btn_OpenLogFolder
            // 
            this.btn_OpenLogFolder.Location = new System.Drawing.Point(655, 12);
            this.btn_OpenLogFolder.Name = "btn_OpenLogFolder";
            this.btn_OpenLogFolder.Size = new System.Drawing.Size(133, 23);
            this.btn_OpenLogFolder.TabIndex = 0;
            this.btn_OpenLogFolder.Text = "예제 폴더 열기";
            this.btn_OpenLogFolder.UseVisualStyleBackColor = true;
            this.btn_OpenLogFolder.Click += new System.EventHandler(this.btn_OpenLogFolder_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(279, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "설정 날짜";
            // 
            // btn_DeleteFile
            // 
            this.btn_DeleteFile.Location = new System.Drawing.Point(37, 135);
            this.btn_DeleteFile.Name = "btn_DeleteFile";
            this.btn_DeleteFile.Size = new System.Drawing.Size(133, 23);
            this.btn_DeleteFile.TabIndex = 2;
            this.btn_DeleteFile.Text = "설정 날짜로 파일 삭제";
            this.btn_DeleteFile.UseVisualStyleBackColor = true;
            this.btn_DeleteFile.Click += new System.EventHandler(this.btn_DeleteFile_Click);
            // 
            // btn_LogTextClear
            // 
            this.btn_LogTextClear.Location = new System.Drawing.Point(213, 73);
            this.btn_LogTextClear.Name = "btn_LogTextClear";
            this.btn_LogTextClear.Size = new System.Drawing.Size(133, 23);
            this.btn_LogTextClear.TabIndex = 2;
            this.btn_LogTextClear.Text = "Log 창 초기화";
            this.btn_LogTextClear.UseVisualStyleBackColor = true;
            this.btn_LogTextClear.Click += new System.EventHandler(this.btn_LogTextClear_Click);
            // 
            // btn_rangeCreate
            // 
            this.btn_rangeCreate.Location = new System.Drawing.Point(436, 29);
            this.btn_rangeCreate.Name = "btn_rangeCreate";
            this.btn_rangeCreate.Size = new System.Drawing.Size(204, 23);
            this.btn_rangeCreate.TabIndex = 0;
            this.btn_rangeCreate.Text = "기간 지정 예제 파일 생성";
            this.btn_rangeCreate.UseVisualStyleBackColor = true;
            this.btn_rangeCreate.Click += new System.EventHandler(this.btn_rangeCreate_Click);
            // 
            // tBox_Range
            // 
            this.tBox_Range.Location = new System.Drawing.Point(540, 61);
            this.tBox_Range.Name = "tBox_Range";
            this.tBox_Range.Size = new System.Drawing.Size(100, 21);
            this.tBox_Range.TabIndex = 5;
            this.tBox_Range.Text = "60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "설정 기간";
            // 
            // btn_RangeDeleteFile
            // 
            this.btn_RangeDeleteFile.Location = new System.Drawing.Point(37, 195);
            this.btn_RangeDeleteFile.Name = "btn_RangeDeleteFile";
            this.btn_RangeDeleteFile.Size = new System.Drawing.Size(442, 23);
            this.btn_RangeDeleteFile.TabIndex = 2;
            this.btn_RangeDeleteFile.Text = "설정 날짜 기준 설정 기간 이전 파일 삭제";
            this.btn_RangeDeleteFile.UseVisualStyleBackColor = true;
            this.btn_RangeDeleteFile.Click += new System.EventHandler(this.btn_RangeDeleteFile_Click);
            // 
            // tBox_DeleteRange
            // 
            this.tBox_DeleteRange.Location = new System.Drawing.Point(138, 224);
            this.tBox_DeleteRange.Name = "tBox_DeleteRange";
            this.tBox_DeleteRange.Size = new System.Drawing.Size(100, 21);
            this.tBox_DeleteRange.TabIndex = 5;
            this.tBox_DeleteRange.Text = "60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "설정 기간";
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBox_DeleteRange);
            this.Controls.Add(this.tBox_Range);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_RangeDeleteFile);
            this.Controls.Add(this.btn_DeleteFile);
            this.Controls.Add(this.btn_LogTextClear);
            this.Controls.Add(this.btn_FolderFileList);
            this.Controls.Add(this.tBox_Log);
            this.Controls.Add(this.btn_OpenLogFolder);
            this.Controls.Add(this.btn_rangeCreate);
            this.Controls.Add(this.btn_CreateLogFile);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateLogFile;
        private System.Windows.Forms.RichTextBox tBox_Log;
        private System.Windows.Forms.Button btn_FolderFileList;
        private System.Windows.Forms.Button btn_OpenLogFolder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DeleteFile;
        private System.Windows.Forms.Button btn_LogTextClear;
        private System.Windows.Forms.Button btn_rangeCreate;
        private System.Windows.Forms.TextBox tBox_Range;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_RangeDeleteFile;
        private System.Windows.Forms.TextBox tBox_DeleteRange;
        private System.Windows.Forms.Label label3;
    }
}

