/****** hennsaisumi  ******/
SELECT
      a.[入力ID] as 取得ID
	   ,a.[取得日付] ,[取引株数]
		 , b.[入力ID] as 返済ID
             
	,  b.[返済日付]
       ,[銘柄コード]
      ,[銘柄名]
     , b.[返済株数]
	, a.[残株数]
  FROM [MyTradeDB].[dbo].[MST_取得] as a
  left join  [MyTradeDB].[dbo].[MST_返済] as b
  on a.入力ID = b.[返済元ID]
  where a.銘柄コード='8766'
  order by  b.[返済日付] 