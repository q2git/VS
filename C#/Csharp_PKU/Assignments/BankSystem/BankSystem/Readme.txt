
测试账号 密码		账号类型
1111	1111	Saving
2222	2222	Saving
3333	3333	Credit

Account/CreditAccount 类都设置为 [Serializable] Attribute

账号信息变更通过 DataStore 类序列化到 DataStore.bin 文件

账号2222目前有超过20000余额，用来测试 BigMoneyFetched 事件

ATM类中取款函数随机产生 BadCashException 异常