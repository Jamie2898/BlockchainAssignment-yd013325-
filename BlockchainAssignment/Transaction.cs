using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Transaction
    {
        public String senderAddress;
        public String recipientAddress;

        DateTime timestamp;
        public String hash;
        String signature;

        public double amount;
        public double fee;

        /// <summary>
        /// Transaction
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="amount"></param>
        /// <param name="fee"></param>
        /// <param name="privateKey"></param>
        public Transaction(String from, String to, double amount, double fee, String privateKey)
        {
            senderAddress = from;
            recipientAddress = to;
            this.amount = amount;
            this.fee = fee;
            timestamp = DateTime.Now;

            hash = CreateHash();
            signature = Wallet.Wallet.CreateSignature(from, privateKey, hash);
        }

        /// <summary>
        /// Use SHA256 to create hash
        /// </summary>
        /// <returns></returns>
        public String CreateHash()
        {
            String hash = String.Empty;
            SHA256 hasher = SHA256Managed.Create();

            String input = senderAddress + recipientAddress + timestamp.ToString() + amount.ToString() + fee.ToString();
            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            foreach (byte x in hashByte)
            {
                hash += String.Format("{0:x2}", x);
            }

            return hash;
        }

        public override string ToString()
        {
            return "Transaction Hash: " + hash + "\n"
                + "Digital Signature: " + signature + "\n"
                + "Timestamp: " + timestamp.ToString() + "\n" 
                + "Transferred: " + amount.ToString() + " AssignmentCoin\n"
                + "Fees: " + fee.ToString() + "\n"
                + "Sender Address: " + senderAddress + "\n"
                + "Receiver Address: " + recipientAddress + "\n";
        }
    }
}
