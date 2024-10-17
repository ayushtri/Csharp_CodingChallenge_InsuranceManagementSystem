using DAOLibrary;
using EntityLibrary;
using ExceptionLibrary;

internal class MainModule
{
    private static void Main(string[] args)
    {
        try
        {
            InsuranceServiceImpl insuranceServiceImpl = new InsuranceServiceImpl();

            int choice;

            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Create Policy");
                Console.WriteLine("2. Get Policy by ID");
                Console.WriteLine("3. Get All Policies");
                Console.WriteLine("4. Update Policy");
                Console.WriteLine("5. Delete Policy");
                Console.WriteLine("6. Exit");
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        // Create a policy
                        Console.Write("Enter Policy Number: ");
                        string polNum = Console.ReadLine();
                        Policy policy1 = new Policy { PolicyNumber = polNum };
                        bool created = insuranceServiceImpl.CreatePolicy(policy1);
                        Console.WriteLine("Policy created: " + created);
                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case 2:
                        // Get a policy by ID
                        Console.Write("Enter policy ID: ");
                        int policyId = Convert.ToInt32(Console.ReadLine());
                        Policy retrievedPolicy = insuranceServiceImpl.GetPolicy(policyId);
                        Console.WriteLine("Retrieved policy: " + retrievedPolicy);
                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case 3:
                        // Get all policies
                        List<Policy> allPolicies = insuranceServiceImpl.GetAllPolicies();
                        Console.WriteLine("All policies:");
                        foreach (Policy policy in allPolicies)
                        {
                            Console.WriteLine(policy);
                        }
                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case 4:
                        // Update a policy
                        Console.Write("Enter policy ID to update: ");
                        int updatePolicyId = Convert.ToInt32(Console.ReadLine());
                        Policy policyToUpdate = insuranceServiceImpl.GetPolicy(updatePolicyId);
                        if (policyToUpdate != null)
                        {
                            Console.Write("Enter new policy number: ");
                            string newPolicyNumber = Console.ReadLine();
                            policyToUpdate.PolicyNumber = newPolicyNumber;
                            bool updated = insuranceServiceImpl.UpdatePolicy(policyToUpdate);
                            Console.WriteLine("Policy updated: " + updated);
                        }
                        else
                        {
                            Console.WriteLine("Policy not found.");
                        }
                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case 5:
                        // Delete a policy
                        Console.Write("Enter policy ID to delete: ");
                        int deletePolicyId = Convert.ToInt32(Console.ReadLine());
                        bool deleted = insuranceServiceImpl.DeletePolicy(deletePolicyId);
                        Console.WriteLine("Policy deleted: " + deleted);
                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case 6:
                        //Exit
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 6);

            Console.Read();
        }
        catch (PolicyNotFoundException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        
    }
}