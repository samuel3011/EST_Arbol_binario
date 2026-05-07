using EST_HanoiTower.Interfaces;
using System.Collections;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;

namespace EST_HanoiTower
{
    public partial class Form1 : Form
    {
        int TowerSize = 0;
        int totalDiscos = 3;
        int movimientos = 0;
        int movimientosMinimos = 0;

        ArrayStack<int> current = new ArrayStack<int>();
        ArrayStack<int> StackA = new ArrayStack<int>();
        ArrayStack<int> StackB = new ArrayStack<int>();
        ArrayStack<int> StackC = new ArrayStack<int>();

        public Form1()
        {
            InitializeComponent();
            ClearLabels();
        }

        private void FillTowerA()
        {
            for (int i = 0; i < TowerSize; i++)
            {
                StackA.Push(TowerSize - i);
            }

            ActualizarListBox();
        }

        private void ClearLabels()
        {
            txtTowerA.Text = string.Empty;
            txtTowerB.Text = string.Empty;
            txtTowerC.Text = string.Empty;
        }

        private void ActualizarListBox()
        {
            TowerA.Items.Clear();
            TowerB.Items.Clear();
            TowerC.Items.Clear();

            DrawTower(StackA, TowerA);
            DrawTower(StackB, TowerB);
            DrawTower(StackC, TowerC);
        }

        private void DrawTower(IStack<int> stack, ListBox tower)
        {
            ArrayStack<int> temp = new ArrayStack<int>();

            while (!stack.IsEmpty())
            {
                int disc = stack.Pop();
                temp.Push(disc);
            }

            while(temp.Count() > 0)
            {
                int disc = temp.Pop();
                stack.Push(disc);
                tower.Items.Add(disc);
            }
        }

        private void CheckWin()
        {
            if(StackC.Count() == TowerSize)
            {
                MessageBox.Show("Haz Ganado!!");

                if (movimientos < movimientosMinimos)
                {
                    MessageBox.Show("Lo hiciste perfecto!");
                }
                else
                {
                    MessageBox.Show("Puedes hacerlo en menos movimientos");
                }
            }
        }

        private void ActualizarContador()
        {
            lblMovimientos.Text = "Movimientos Realizados: " + movimientos;
            lblMinimos.Text = "Movimientos Mínimos: " + movimientosMinimos;
        }
        

        private void btnSelectA_Click(object sender, EventArgs e)
        {
            ClearLabels();
            current = StackA;
            txtTowerA.Text = "Seleccionado";
        }

        private void btnSelectB_Click(object sender, EventArgs e)
        {
            ClearLabels();
            current = StackB;
            txtTowerB.Text = "Seleccionado";
        }

        private void btnSelectC_Click(object sender, EventArgs e)
        {
            ClearLabels();
            current = StackC;
            txtTowerC.Text = "Seleccionado";
        }

        private void btnMoveA_Click(object sender, EventArgs e)
        {
            ClearLabels();
            if (current.IsEmpty()) return;

            if (current == StackA) return;

            if (!StackA.IsEmpty() && current.Peek() > StackA.Peek())
            {
                MessageBox.Show("Movimiento Invalido!");
                return;
            }

            movimientos++;
            StackA.Push(current.Peek());
            Pop();
            ActualizarListBox();
            ActualizarContador();
            CheckWin();
        }

        private void btnMoveB_Click(object sender, EventArgs e)
        {
            ClearLabels();
            if (current.IsEmpty()) return;

            if (current == StackB) return;

            if (!StackB.IsEmpty() && current.Peek() > StackB.Peek())
            {
                MessageBox.Show("Movimiento Invalido!");
                return;
            }

            movimientos++;
            StackB.Push(current.Peek());
            Pop();
            ActualizarListBox();
            ActualizarContador();
            CheckWin();
        }

        private void btnMoveC_Click(object sender, EventArgs e)
        {
            ClearLabels();
            if (current.IsEmpty()) return;

            if (current == StackC) return;

            if (!StackC.IsEmpty() && current.Peek() > StackC.Peek())
            {
                MessageBox.Show("Movimiento Invalido!");
                return;
            }

            movimientos++;
            StackC.Push(current.Peek());
            Pop();
            ActualizarListBox();
            ActualizarContador();
            CheckWin();
        }

        private void Pop()
        {
            if (current.IsEmpty())
            {
                MessageBox.Show("La lista está vacía");
                
            }
            else
            {
                current.Pop();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtCant.Text == null) return;

            if (int.TryParse(txtCant.Text, out TowerSize) && TowerSize > 0)
            {
                movimientos = 0;
                movimientosMinimos = (int)Math.Pow(2, totalDiscos) - 1;

                FillTowerA();
                ActualizarContador();
            }
            else 
            {
                MessageBox.Show("Por favor, ingrese un número entero.");
                txtCant.Text = string.Empty;
            }
        }
    }
}
