﻿using System;
namespace Cs_Playground.DesignPattern
{
    public abstract class Algorithm
    {
        public void FinishOneTask() {
            StepOne();
            StepTwo();
            StepThree();
        }

        public abstract void StepOne();
        public abstract void StepTwo();
        public abstract void StepThree();
    }

    public class AlgorithmA : Algorithm
    {
        public override void StepOne()
        {
            Console.WriteLine("step1");
        }

        public override void StepThree()
        {
            Console.WriteLine("step2");
        }

        public override void StepTwo()
        {
            Console.WriteLine("step3");
        }
    }
}
