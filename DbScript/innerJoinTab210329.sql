/****** SSMS の SelectTopNRows コマンドのスクリプト  ******/
SELECT　a.入力ID ,a.銘柄コード　,a.銘柄名 ,a.取得日付
,b.返済元ID ,b.返済日付
  FROM [MyTradeDB].[dbo].[MST_取得] as a　
  inner join
  [MyTradeDB].[dbo].[MST_返済] as b	　on a.入力ID = b.返済元ID
 where  取得日付>='2021/1/1' and 取得日付<'2021/2/1'
/*銘柄コード=9984*/