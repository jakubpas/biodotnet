using System;
using System.Collections.Generic;
using System.Linq;
using Bio;
using Bio.Algorithms.Alignment.MultipleSequenceAlignment;
using Bio.IO.FastA;
using Bio.SimilarityMatrices;
using NUnit.Framework;
using Bio.Tests;

namespace Bio.Pamsam.Tests
{
    /// <summary>
    /// Test for MuscleMultipleSequenceAlignment class
    /// </summary>
    [TestFixture]
    public class PAMSAMMultipleSequenceAlignmentTests
    {
        [Test]
        public void TestName()
        {
            PAMSAMMultipleSequenceAligner aligner = new PAMSAMMultipleSequenceAligner();
            Assert.AreEqual("PAMSAM (MUSCLE)", aligner.Name);
        }

        /// <summary>
        /// Test MuscleMultipleSequenceAlignment class
        /// </summary>
        [Test]
        public void TestMuscleMultipleSequenceAlignment()
        {

            SimilarityMatrix similarityMatrix = new SimilarityMatrix(SimilarityMatrix.StandardSimilarityMatrix.AmbiguousDna);
            int gapOpenPenalty = -4;
            int gapExtendPenalty = -1;
            int kmerLength = 3;

            ISequence seqA = new Sequence(Alphabets.DNA, "GGGAAAAATCAGATT");
            ISequence seqB = new Sequence(Alphabets.DNA, "GGGAATCAAAATCAG");
            ISequence seqC = new Sequence(Alphabets.DNA, "GGGACAAAATCAG");
            List<ISequence> sequences = new List<ISequence>();
            sequences.Add(seqA);
            sequences.Add(seqB);
            sequences.Add(seqC);

            DistanceFunctionTypes distanceFunctionName = DistanceFunctionTypes.EuclideanDistance;
            UpdateDistanceMethodsTypes hierarchicalClusteringMethodName = UpdateDistanceMethodsTypes.Average;
            ProfileAlignerNames profileAlignerName = ProfileAlignerNames.NeedlemanWunschProfileAligner;
            ProfileScoreFunctionNames profileProfileFunctionName = ProfileScoreFunctionNames.WeightedInnerProduct;

            PAMSAMMultipleSequenceAligner msa = new PAMSAMMultipleSequenceAligner
                (sequences, kmerLength, distanceFunctionName, hierarchicalClusteringMethodName,
                profileAlignerName, profileProfileFunctionName, similarityMatrix, gapOpenPenalty, gapExtendPenalty,
                Environment.ProcessorCount * 2, Environment.ProcessorCount);

            Console.WriteLine("Aligned sequences in stage 1: {0}", msa.AlignmentScoreA);
            for (int i = 0; i < msa.AlignedSequencesA.Count; ++i)
            {
                Console.WriteLine(new string(msa.AlignedSequencesA[i].Select(a => (char)a).ToArray()));
            }
            
            Console.WriteLine("Aligned sequences in stage 3: {0}", msa.AlignmentScoreC);
            for (int i = 0; i < msa.AlignedSequencesC.Count; ++i)
            {
                Console.WriteLine(new string(msa.AlignedSequencesC[i].Select(a => (char)a).ToArray()));
            }
            Console.WriteLine("Aligned sequences final: {0}", msa.AlignmentScore);

            for (int i = 0; i < msa.AlignedSequences.Count; ++i)
            {
                Console.WriteLine(new string(msa.AlignedSequences[i].Select(a => (char)a).ToArray()));
            }

            // Test case 2
            Console.WriteLine("Example 2");
            sequences = new List<ISequence>();
            sequences.Add(new Sequence(Alphabets.DNA, "GGGAAAAATCAGATT"));
            sequences.Add(new Sequence(Alphabets.DNA, "GGGAATCAAAATCAG"));
            sequences.Add(new Sequence(Alphabets.DNA, "GGGAATCAAAATCAG"));
            sequences.Add(new Sequence(Alphabets.DNA, "GGGAAATCG"));
            sequences.Add(new Sequence(Alphabets.DNA, "GGGAATCAATCAG"));
            sequences.Add(new Sequence(Alphabets.DNA, "GGGAATCTTATCAG"));
            sequences.Add(new Sequence(Alphabets.DNA, "GGGACAAAATCAG"));
            sequences.Add(new Sequence(Alphabets.DNA, "GGGAAAAATCAGATT"));
            sequences.Add(new Sequence(Alphabets.DNA, "GGGAATCAAAATCAG"));
            sequences.Add(new Sequence(Alphabets.DNA, "GGGACAAAATCAG"));


            msa = new PAMSAMMultipleSequenceAligner
                (sequences, kmerLength, distanceFunctionName, hierarchicalClusteringMethodName,
                profileAlignerName, profileProfileFunctionName, similarityMatrix, gapOpenPenalty, gapExtendPenalty,
                Environment.ProcessorCount * 2, Environment.ProcessorCount);

            Console.WriteLine("Aligned sequences in stage 1: {0}", msa.AlignmentScoreA);
            for (int i = 0; i < msa.AlignedSequencesA.Count; ++i)
            {
                Console.WriteLine(new string(msa.AlignedSequencesA[i].Select(a => (char)a).ToArray()));
            }
            
            Console.WriteLine("Aligned sequences in stage 3: {0}", msa.AlignmentScoreC);
            for (int i = 0; i < msa.AlignedSequencesC.Count; ++i)
            {
                Console.WriteLine(new string(msa.AlignedSequencesC[i].Select(a => (char)a).ToArray()));
            }
            Console.WriteLine("Aligned sequences final: {0}", msa.AlignmentScore);
            for (int i = 0; i < msa.AlignedSequences.Count; ++i)
            {
                Console.WriteLine(new string(msa.AlignedSequences[i].Select(a => (char)a).ToArray()));
            }

            // Test case e
            Console.WriteLine("Example 2");
            sequences = new List<ISequence>();
            sequences.Add(new Sequence(Alphabets.DNA, "GGGAAAAATCAGATT"));
            sequences.Add(new Sequence(Alphabets.DNA, "GGGAATCAAAATCAG"));
            sequences.Add(new Sequence(Alphabets.DNA, "GGGAATCAAAATCAG"));
            sequences.Add(new Sequence(Alphabets.DNA, "GGGAAATCG"));
            sequences.Add(new Sequence(Alphabets.DNA, "GGGAATCAATCAG"));
            sequences.Add(new Sequence(Alphabets.DNA, "GGGACAAAATCAG"));
            sequences.Add(new Sequence(Alphabets.DNA, "GGGAATCTTATCAG"));


            msa = new PAMSAMMultipleSequenceAligner
                (sequences, kmerLength, distanceFunctionName, hierarchicalClusteringMethodName,
                profileAlignerName, profileProfileFunctionName, similarityMatrix, gapOpenPenalty, gapExtendPenalty,
                Environment.ProcessorCount * 2, Environment.ProcessorCount);

            Console.WriteLine("Aligned sequences in stage 1: {0}", msa.AlignmentScoreA);
            for (int i = 0; i < msa.AlignedSequencesA.Count; ++i)
            {
                Console.WriteLine(new string(msa.AlignedSequencesA[i].Select(a => (char)a).ToArray()));
            }
            
            Console.WriteLine("Aligned sequences in stage 3: {0}", msa.AlignmentScoreC);
            for (int i = 0; i < msa.AlignedSequencesC.Count; ++i)
            {
                Console.WriteLine(new string(msa.AlignedSequencesC[i].Select(a => (char)a).ToArray()));
            }
            Console.WriteLine("Aligned sequences final: {0}", msa.AlignmentScore);
            for (int i = 0; i < msa.AlignedSequences.Count; ++i)
            {
                Console.WriteLine(new string(msa.AlignedSequences[i].Select(a => (char)a).ToArray()));
            }

        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TestMuscleMultipleSequenceAlignmentRunningTime()
        {
            string filepath = @"TestUtils\Fasta\RunningTime\BOX246.xml.afa".TestDir();

            // Test on DNA benchmark dataset
            FastAParser parser = new FastAParser();

            IList<ISequence> orgSequences = parser.Parse(filepath).ToList();

            List<ISequence> sequences = MsaUtils.UnAlign(orgSequences);

            //filepath = @"TestUtils\Fasta\RunningTime\12_raw.afa";
            //List<ISequence> sequences = parser.Parse(filepath);

            int numberOfSequences = orgSequences.Count;

            Console.WriteLine("Original sequences are:");
            for (int i = 0; i < numberOfSequences; ++i)
            {
                Console.WriteLine(new string(sequences[i].Select(a => (char)a).ToArray()));
            }

            Console.WriteLine("Benchmark sequences are:");
            for (int i = 0; i < numberOfSequences; ++i)
            {
                Console.WriteLine(new string(orgSequences[i].Select(a => (char)a).ToArray()));
            }

            PAMSAMMultipleSequenceAligner.FasterVersion = true;
            PAMSAMMultipleSequenceAligner.UseWeights = false;
            PAMSAMMultipleSequenceAligner.UseStageB = false;
            PAMSAMMultipleSequenceAligner.NumberOfCores = 2;

            int gapOpenPenalty = -13;
            int gapExtendPenalty = -5;
            int kmerLength = 2;

            int numberOfDegrees = 2;//Environment.ProcessorCount;
            int numberOfPartitions = 16;// Environment.ProcessorCount * 2;


            DistanceFunctionTypes distanceFunctionName = DistanceFunctionTypes.EuclideanDistance;
            UpdateDistanceMethodsTypes hierarchicalClusteringMethodName = UpdateDistanceMethodsTypes.Average;
            ProfileAlignerNames profileAlignerName = ProfileAlignerNames.NeedlemanWunschProfileAligner;
            ProfileScoreFunctionNames profileProfileFunctionName = ProfileScoreFunctionNames.InnerProductFast;

            SimilarityMatrix similarityMatrix = new SimilarityMatrix(SimilarityMatrix.StandardSimilarityMatrix.Blosum62);

            PAMSAMMultipleSequenceAligner msa = new PAMSAMMultipleSequenceAligner
               (sequences, kmerLength, distanceFunctionName, hierarchicalClusteringMethodName,
               profileAlignerName, profileProfileFunctionName, similarityMatrix, gapOpenPenalty, gapExtendPenalty,
               numberOfPartitions, numberOfDegrees);
            Console.WriteLine("The number of partitions is: {0}", numberOfPartitions);
            Console.WriteLine("The number of degrees is: {0}", numberOfDegrees);
            Console.WriteLine("Alignment score Q is: {0}", MsaUtils.CalculateAlignmentScoreQ(msa.AlignedSequences, orgSequences));
            Console.WriteLine("Alignment score TC is: {0}", MsaUtils.CalculateAlignmentScoreTC(msa.AlignedSequences, orgSequences));



            Console.WriteLine("Benchmark SPS score is: {0}", MsaUtils.MultipleAlignmentScoreFunction(orgSequences, similarityMatrix, gapOpenPenalty, gapExtendPenalty));
            Console.WriteLine("Aligned sequences in stage 1: {0}", msa.AlignmentScoreA);
            for (int i = 0; i < msa.AlignedSequencesA.Count; ++i)
            {
                Console.WriteLine(new string(msa.AlignedSequencesA[i].Select(a => (char)a).ToArray()));
            }
            Console.WriteLine("Alignment score Q is: {0}", MsaUtils.CalculateAlignmentScoreQ(msa.AlignedSequencesA, orgSequences));
            Console.WriteLine("Alignment score TC is: {0}", MsaUtils.CalculateAlignmentScoreTC(msa.AlignedSequencesA, orgSequences));
            Console.WriteLine("Aligned sequences in stage 2: {0}", msa.AlignmentScoreB);
            for (int i = 0; i < msa.AlignedSequencesB.Count; ++i)
            {
                Console.WriteLine(new string(msa.AlignedSequencesB[i].Select(a => (char)a).ToArray()));
            }
            Console.WriteLine("Alignment score Q is: {0}", MsaUtils.CalculateAlignmentScoreQ(msa.AlignedSequencesB, orgSequences));
            Console.WriteLine("Alignment score TC is: {0}", MsaUtils.CalculateAlignmentScoreTC(msa.AlignedSequencesB, orgSequences));
            Console.WriteLine("Aligned sequences in stage 3: {0}", msa.AlignmentScoreC);
            for (int i = 0; i < msa.AlignedSequencesC.Count; ++i)
            {
                Console.WriteLine(new string(msa.AlignedSequencesC[i].Select(a => (char)a).ToArray()));
            }
            Console.WriteLine("Alignment score Q is: {0}", MsaUtils.CalculateAlignmentScoreQ(msa.AlignedSequencesC, orgSequences));
            Console.WriteLine("Alignment score TC is: {0}", MsaUtils.CalculateAlignmentScoreTC(msa.AlignedSequencesC, orgSequences));
            Console.WriteLine("Aligned sequences final: {0}", msa.AlignmentScore);
            for (int i = 0; i < msa.AlignedSequences.Count; ++i)
            {
                Console.WriteLine(new string(msa.AlignedSequences[i].Select(a => (char)a).ToArray()));
            }
            Console.WriteLine("Alignment score Q is: {0}", MsaUtils.CalculateAlignmentScoreQ(msa.AlignedSequences, orgSequences));
            Console.WriteLine("Alignment score TC is: {0}", MsaUtils.CalculateAlignmentScoreTC(msa.AlignedSequences, orgSequences));
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void testBug()
        {
            ISequence seq1 = new Sequence(Alphabets.Protein, "MQEPQSELNIDPPLSQETFSELWNLLPENNVLSSELCPAVDELLLPESVVNWLDEDSDDAPRMPATSAP");
            ISequence seq2 = new Sequence(Alphabets.Protein, "PLSQETFSDLWNLLPENNLLSSELSAPVDDLLPYTDVATWLDECPNEAPQMPEPSAPAAPPPATPAPATSWPLSSFVPSQKTYPGNYGFRLGF");
            ISequence seq3 = new Sequence(Alphabets.Protein, "MEPSSETGMDPPLSQETFEDLWSLLPDPLQTVTCRLDNLSEFPDYPLAADMSVLQEGLMGNAVPTVTSCAPSTDDYAGKYGLQLDFQQNGTAKS");
            ISequence seq4 = new Sequence(Alphabets.Protein, "MEEPQSDPSVEPPLSQETFSDLWKLLPENNVLSPLPSQAMDDLMLSPDDIEQWFTEDPGPDEAPRMPEAAPRVAPAPAAPTPAAPAPAPSWPLS");
            ISequence seq5 = new Sequence(Alphabets.Protein, "MEESQAELGVEPPLSQETFSDLWKLLPENNLLSSELSPAVDDLLLSPEDVANWLDERPDEAPQMPEPPAPAAPTPAAPAPATSWPLSSFVPSQK");
            ISequence seq6 = new Sequence(Alphabets.Protein, "MTAMEESQSDISLELPLSQETFSGLWKLLPPEDILPSPHCMDDLLLPQDVEEFFEGPSEALRVSGAPAAQDPVTETPGPVAPAPATPWPLSSFVPSQKTYQGNYGFHLGFLQ");
            ISequence seq7 = new Sequence(Alphabets.Protein, "FRLGFLHSGTAKSVTWTYSPLLNKLFCQLAKTCPVQLWVSSPPPPNTCVRAMAIYKKSEFVTEVVRRCPHHERCSDSSDGLAPPQHLIRVEGNLRAKYLDDRNTFRHSVV");

            List<ISequence> sequences = new List<ISequence>
            {
                seq1,
                seq2,
                seq3,
                seq4,
                seq5,
                seq6,
                seq7
            };

            PAMSAMMultipleSequenceAligner msa = new PAMSAMMultipleSequenceAligner(sequences,
                2, DistanceFunctionTypes.EuclideanDistance, 
                UpdateDistanceMethodsTypes.Average, 
                ProfileAlignerNames.NeedlemanWunschProfileAligner,
                ProfileScoreFunctionNames.WeightedEuclideanDistance,
                new SimilarityMatrix(SimilarityMatrix.StandardSimilarityMatrix.Blosum50), 
                -8, -1, 2, 16);

            Assert.IsNotNull(msa.AlignedSequences);
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void testBug2()
        {
            //Test on DNA benchmark dataset
            string filepath = @"TestUtils\122_raw.afa".TestDir();
            FastAParser parser = new FastAParser();

            IList<ISequence> orgSequences = parser.Parse(filepath).ToList();

            List<ISequence> sequences = MsaUtils.UnAlign(orgSequences);

            PAMSAMMultipleSequenceAligner.FasterVersion = false;
            PAMSAMMultipleSequenceAligner.UseWeights = false;
            PAMSAMMultipleSequenceAligner.UseStageB = false;
            PAMSAMMultipleSequenceAligner.NumberOfCores = 2;

            int gapOpenPenalty = -13;
            int gapExtendPenalty = -5;
            int kmerLength = 2;
            int numberOfDegrees = 2;//Environment.ProcessorCount;
            int numberOfPartitions = 16;// Environment.ProcessorCount * 2;

            DistanceFunctionTypes distanceFunctionName = DistanceFunctionTypes.EuclideanDistance;
            UpdateDistanceMethodsTypes hierarchicalClusteringMethodName = UpdateDistanceMethodsTypes.Average;
            ProfileAlignerNames profileAlignerName = ProfileAlignerNames.NeedlemanWunschProfileAligner;
            ProfileScoreFunctionNames profileProfileFunctionName = ProfileScoreFunctionNames.InnerProductFast;

            SimilarityMatrix similarityMatrix =  new SimilarityMatrix(SimilarityMatrix.StandardSimilarityMatrix.AmbiguousDna);

            PAMSAMMultipleSequenceAligner msa = new PAMSAMMultipleSequenceAligner
               (sequences, kmerLength, distanceFunctionName, hierarchicalClusteringMethodName,
               profileAlignerName, profileProfileFunctionName, similarityMatrix, gapOpenPenalty, gapExtendPenalty,
               numberOfPartitions, numberOfDegrees);

            Assert.IsNotNull(msa.AlignedSequences);
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void testBug3()
        {
            //Test on DNA benchmark dataset
            string filepath = @"TestUtils\122_raw.afa".TestDir();
            FastAParser parser = new FastAParser();

            IList<ISequence> orgSequences = parser.Parse(filepath).ToList();

            List<ISequence> sequences = MsaUtils.UnAlign(orgSequences);

            PAMSAMMultipleSequenceAligner.FasterVersion = false;
            PAMSAMMultipleSequenceAligner.UseWeights = false;
            PAMSAMMultipleSequenceAligner.UseStageB = false;
            PAMSAMMultipleSequenceAligner.NumberOfCores = 2;

            int gapOpenPenalty = -13;
            int gapExtendPenalty = -5;
            int kmerLength = 2;

            int numberOfDegrees = 2;//Environment.ProcessorCount;
            int numberOfPartitions = 16;// Environment.ProcessorCount * 2;


            DistanceFunctionTypes distanceFunctionName = DistanceFunctionTypes.EuclideanDistance;
            UpdateDistanceMethodsTypes hierarchicalClusteringMethodName = UpdateDistanceMethodsTypes.Average;
            ProfileAlignerNames profileAlignerName = ProfileAlignerNames.NeedlemanWunschProfileAligner;
            ProfileScoreFunctionNames profileProfileFunctionName = ProfileScoreFunctionNames.InnerProductFast;

            SimilarityMatrix similarityMatrix = new SimilarityMatrix(SimilarityMatrix.StandardSimilarityMatrix.AmbiguousDna);
                  
            //DateTime startTime = DateTime.Now;
            PAMSAMMultipleSequenceAligner msa = new PAMSAMMultipleSequenceAligner
               (sequences, kmerLength, distanceFunctionName, hierarchicalClusteringMethodName,
               profileAlignerName, profileProfileFunctionName, similarityMatrix, gapOpenPenalty, gapExtendPenalty,
               numberOfPartitions, numberOfDegrees);
            Assert.IsNotNull(msa.AlignedSequences);
        }
    }
}
