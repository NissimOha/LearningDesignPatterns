using System.Collections.Generic;
using System;
using System.Windows.Forms;
using Nissim.On.Command.Ifc;
using Nissim.On.Command.BL;

namespace Nissim.On.Command
{
    public partial class smartHomeController : Form
    {
        #region Initilaizes

        public smartHomeController(List<ICommand> p_buttonsCommands, Worker p_worker)
        {
            InitializeComponent();
            initilaizeLists();
            initializeCommands(p_buttonsCommands);
            m_worker = p_worker;
            m_worker.ExecuteFinished += updateScreen;
        }

        private void initilaizeLists()
        {
            m_buttonsCommands = new List<ICommand>();
            m_doStack = new Stack<ICommand>();
            m_unDoStack = new Stack<ICommand>();
        }

        private void initializeCommands(List<ICommand> p_buttonsCommands)
        {
            foreach (var buttonCommand in p_buttonsCommands)
            {
                m_buttonsCommands.Add(buttonCommand);
            }
        }

        #endregion

        #region ButtonClick

        // On click methods, execute the needed process and save the command for undoing.
        private void redButton_Click(object p_sender, EventArgs p_e)
        {
            m_buttonsCommands[(int)ButtonsColorIndex.Red].execute();
            m_unDoStack.Push(m_buttonsCommands[(int)ButtonsColorIndex.Red]);
        }

        private void greenButton_Click(object p_sender, EventArgs p_e)
        {
            m_buttonsCommands[(int)ButtonsColorIndex.Green].execute();
            m_unDoStack.Push(m_buttonsCommands[(int)ButtonsColorIndex.Green]);
        }

        private void blueButton_Click(object p_sender, EventArgs p_e)
        {
            m_buttonsCommands[(int)ButtonsColorIndex.Blue].execute();
            m_unDoStack.Push(m_buttonsCommands[(int)ButtonsColorIndex.Blue]);
        }

        private void blackButton_Click(object p_sender, EventArgs p_e)
        {
            m_buttonsCommands[(int)ButtonsColorIndex.Black].execute();
            m_unDoStack.Push(m_buttonsCommands[(int)ButtonsColorIndex.Black]);
        }

        /// <summary>
        /// Undo the last command.
        /// </summary>
        /// <param name="p_sender"></param>
        /// <param name="p_e"></param>
        private void undoButton_Click(object p_sender, EventArgs p_e)
        {
            if (m_unDoStack.Count != 0)
            {
                var lastCommand = m_unDoStack.Pop();
                m_doStack.Push(lastCommand);
                lastCommand.unexecute();
            }
        }

        /// <summary>
        /// Do the last command.
        /// </summary>
        /// <param name="p_sender"></param>
        /// <param name="p_e"></param>
        private void doButton_Click(object p_sender, EventArgs p_e)
        {
            if (m_doStack.Count != 0)
            {
                var lastCommand = m_doStack.Pop();
                m_unDoStack.Push(lastCommand);
                lastCommand.execute();
            }
        }

        #endregion

        #region UpdateScreen

        /// <summary>
        /// Update the screen after the command done and the event CommadResultEventArgs araise.
        /// </summary>
        /// <param name="p_sender"></param>
        /// <param name="p_commandResultEventArgs"></param>
        private void updateScreen(object p_sender, CommadResultEventArgs p_commandResultEventArgs)
        {
            if (InvokeRequired)
            {
                Invoke((Action)(() => updateScreen(p_sender, p_commandResultEventArgs)));
            }
            else
            {
                resultTextBox.Text = p_commandResultEventArgs.Result;
                if (p_commandResultEventArgs.Work)
                    backResultPanel.BackColor = System.Drawing.Color.Yellow;
                else
                    backResultPanel.BackColor = System.Drawing.Color.White;
            }
        }

        #endregion

        #region Private Members

        /// <summary>
        /// Contain all of the do commands.
        /// </summary>
        private Stack<ICommand> m_doStack;

        /// <summary>
        /// Contain all of the undo commands.
        /// </summary>
        private Stack<ICommand> m_unDoStack;

        /// <summary>
        /// Buttons commands, choosen by the user (order by: Red,green,blue,black).
        /// </summary>
        private List<ICommand> m_buttonsCommands;

        /// <summary>
        /// Contain the executer work.
        /// </summary>
        private Worker m_worker;

        /// <summary>
        /// Number of buttons in the controller.
        /// </summary>
        private const int NUMBEROFBUTTONS = 4;

        /// <summary>
        /// Indicate in witch index the button color is.
        /// </summary>
        private enum ButtonsColorIndex
        {
            Red,
            Green,
            Blue,
            Black
        }

        #endregion
    }
}
