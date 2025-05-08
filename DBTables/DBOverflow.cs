namespace DBTables.Overflow

{

    public class Comment {
        
        public int id;
        
        public Datetime creationDate;

        public int postId;

        public int? score;

        public string text;

        public int userId;

        public Comment(int id, DateTime creationDate, int postId, int score, string text, int userId) {
            this.id = id;
            this.creationDate = creationDate;
            this.postId = postId;
            this.score = score;
            this.text = text;
            this.userId = userId;
        }

        public Comment(string text) {
            this.text = text;
        }

    }

}
