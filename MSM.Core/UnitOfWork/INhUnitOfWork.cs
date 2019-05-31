namespace MSM.Core.UnitOfWork
{
    public interface INhUnitOfWork
    {
        /// <summary>
        /// EN / Open new transaction, this will use in UnitOfWorkInterceptor!
        /// TR / Yeni bir transaction başlatır, UnitOfWork interceptor'ında kullanılacak.
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// EN / Commit all actions in transaction, if success.
        /// TR / Başlatılan transaction içinde tüm işlemler başarılıysa, değişiklikleri database seviyesinde kaydedecek.
        /// UnitOfWork interceptor'ında kullanılacak.
        /// </summary>
        void Commit();

        /// <summary>
        /// EN / Rollback all actions in transaction, if failed.
        /// TR / Başlatılan transaction içinde bir hata oluştuysa, yapılan tüm değişiklikleri geri alacak.
        /// UnitOfWork interceptor'ında kullanılacak.
        /// </summary>
        void Rollback();
    }
}
