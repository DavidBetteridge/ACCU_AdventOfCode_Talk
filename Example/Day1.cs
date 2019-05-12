using System;
using System.IO;
using System.Linq;
using Xunit;

namespace Example
{
    public class Day1Tests
    {
        private string[] _lines;
        private int _total;

        [Fact]
        public void Part1_SampleInput()
        {

            Given_a_file_containing_sample_inputs();

            When_the_part1_solution_is_applied();

            Then_the_result_is_minus6();
        }

        [Fact]
        public void Part1_RealInput()
        {

            Given_a_file_containing_real_inputs();

            When_the_part1_solution_is_applied();

            Then_the_result_is_minus6();
        }


        private void Then_the_result_is_minus6()
        {
            Assert.Equal(-6, _total);
        }

        private void When_the_part1_solution_is_applied()
        {
            _total = _lines.Sum(l => int.Parse(l));
        }

        private void Given_a_file_containing_sample_inputs()
        {
            _lines = File.ReadAllLines("Day1_Part1_Sample.txt");
        }

        private void Given_a_file_containing_real_inputs()
        {
            _lines = File.ReadAllLines("Day1_Part1_Real.txt");
        }
    }
}
