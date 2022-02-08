using LeetCode.Solves.Base;

namespace LeetCode.Solves.MergeTwoSortedLists
{
    public class MergeTwoSortedLists : BaseSolution<ListNode, ListNode, ListNode>
    {

        public override ListNode Solve(ListNode param1, ListNode param2)
        {
            List<int> list = new List<int>();
            ParseInput(param1, list);
            ParseInput(param2, list);
            list.Sort();
            if (list.Count > 0)
            {
                ListNode result = new ListNode();
                BuildNodes(list, result);
                return result;
            }

            return null;
        }

        private void ParseInput(ListNode param, List<int> list)
        {
            if (param == null)
            {
                return;
            }

            list.Add(param.val);
            if (param.next != null)
            {
                ParseInput(param.next, list);
            }
        }

        private ListNode BuildNodes(List<int> list, ListNode result)
        {
            if (list.Count == 0)
            {
                return null;
            }

            result.val = list[0];
            list.RemoveAt(0);
            result.next = BuildNodes(list, new ListNode());
            return result;
        }

    }
}
