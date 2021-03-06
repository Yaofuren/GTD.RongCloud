齐集科技融云开发库
=================
这是一个融云Server API C# SDK类库，以
[融云官方DOTNET库](https://github.com/rongcloud/server-sdk-dotnet) 为基础开发。

# 更新日志

1.0.2.14-在TxtMessage用作自定义消息时，废弃Extra直接使用Content内容作为参数值

1.0.2.13-修复自定义消息默认以RC:开头不能修改的问题，现在完全自定义了

1.0.2.12-增加自定义消息，使得可以通过Txtmsg发送自定义消息类型

# API文档
- 官方文档(http://www.rongcloud.cn/docs/server.html)

# 使用教程

- 请参考 Example.cs 上面提供了所有的 API 接口的调用用例。

## 高级API接口
### User
- getToken  获取 Token
- refresh  刷新用户信息
- checkOnline  检查用户在线状态
- block  封禁用户
- unBlock  解除用户封禁
- queryBlock  获取被封禁用户
- addBlacklist  添加用户到黑名单
- queryBlacklist  获取某用户的黑名单列表
- removeBlacklist  从黑名单中移除用户

### Message
- publishPrivate  发送单聊消息
- publishTemplate  发送单聊模板消息
- PublishSystem  发送系统消息
- PublishCusSystem  发送自定义系统消息
- publishSystemTemplate  发送系统模板消息
- publishGroup  发送群组消息
- publishDiscussion  发送讨论组消息
- publishChatroom  发送聊天室消息
- broadcast  发送广播消息
- getHistory  消息历史记录下载地址获取 消息历史记录下载地址获取。获取 APP 内指定某天某小时内的所有会话消息记录的下载地址
- deleteMessage  消息历史记录删除

### Wordfilter
- add  添加敏感词
- delete  移除敏感词
- getList  查询敏感词列表

### Group
- create  创建群组
- sync  同步用户所属群组
- refresh  刷新群组信息
- join  将用户加入指定群组，用户将可以收到该群的消息，同一用户最多可加入 500 个群，每个群最大至 3000 人
- queryUser  查询群成员
- quit  退出群组
- addGagUser  添加禁言群成员
- lisGagUser  查询被禁言群成员
- rollBackGagUser  移除禁言群成员
- dismiss  解散群组。

### Chatroom
- create  创建聊天室
- join  加入聊天室
- query  查询聊天室信息
- queryUser  查询聊天室内用户
- stopDistributionMessage  聊天室消息停止分发
- resumeDistributionMessage  聊天室消息恢复分发
- addGagUser  添加禁言聊天室成员
- ListGagUser  查询被禁言聊天室成员
- rollbackGagUser  移除禁言聊天室成员
- addBlockUser  添加封禁聊天室成员
- getListBlockUser  查询被封禁聊天室成员
- rollbackBlockUser  移除封禁聊天室成员
- destroy  销毁聊天室
- addWhiteListUser  添加聊天室白名单成员

### Push
- setUserPushTag  添加 Push 标签
- broadcastPush  广播消息

### SMS
- getImageCode  获取图片验证码
- sendCode  发送短信验证码
- verifyCode  验证码验证