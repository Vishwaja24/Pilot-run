/*
* Name: Vishwaja Painjane
* email: painjavv@mail.uc.edu
* Assignment Number: Final Group Project
* Due Date: Tuesday, December 10th, 2024
* Course #/Section: IS3050-001
* Semester/Year: Fall 2024
* Brief Description of the assignment: This is our final group assignment. We had to solve one leetcode problem each.
* Brief Description of what this module does: This is a final group project
* Citations: Used Leetcode.com for the problem and ChatGPT for the solution.
* Anything else that's relevant: N/A
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pilot_run
{
    public partial class Index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSolveProblem_Click(object sender, EventArgs e)
        {
            {
                // Initialize the test case (unsorted array)
                int[] testCase = new int[] { 3, 4, -1, 1 };

                // Create an instance of the Solution class
                Class1 solution = new Class1();

                // Call the FirstMissingPositive method to solve the problem
                int result = solution.FirstMissingPositive(testCase);

                // Display the result in the label
                lblResult.Text = "Smallest Missing Positive Integer: " + result;
            }
        }
    }
}