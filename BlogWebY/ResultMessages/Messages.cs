namespace BlogWebY.ResultMessages
{
    public static class Messages
    {
        public static class Article
        {
            public static string Add(string articleTitle)
            {
                return $"{articleTitle} baslikli makale basariyla eklenmistir";
            }

            public static string Update(string articleTitle)
            {
                return $"{articleTitle} baslikli makale basariyla eklenmistir";
            }
            public static string Delete(string articleTitle)
            {
                return $"{articleTitle} baslikli makale basariyla silinmistir";
            }
        }

        public static class Category
        {
            public static string Add(string categoryName)
            {
                return $"{categoryName} baslikli kategori basariyla eklenmistir";
            }

            public static string Update(string categoryName)
            {
                return $"{categoryName} baslikli kategori basariyla eklenmistir";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} baslikli kategori basariyla silinmistir";
            }
        }

    }
}
