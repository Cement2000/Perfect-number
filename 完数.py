# import time,shutil,os,sys
import time

time_start=time.process_time()

#===============================
#      这是一个求完数的程序
#===============================

# n=6
# n=496
# n=8128
# n=33550336; #家中台式机运行时长8s
# n=8589869056; #家中台式机运行时长43min ,   公司笔记本30 min

n=8589869056

s=0 #求和
k=0 #换行计数，每6个数一行 
i=1 #循环累加用
while i<=n/2:
    if n%i==0:
        s=s+i
        k=k+1
        #sys.stdout.write("%12d"%i)
        print("%12d"%i,end='') #用end=' '方式不换行
        if k%6==0:
            print('')          #换行
    i=i+1

if s==n:
    print("\n\n %12d是完数\n" %n);
else :
    print("\n\n %12d不是完数\n" %n);

time_end=time.process_time()
print('totally cost',time_end-time_start,'s')        
print("\n\n End");
input()

#由于数字比较大，所以运行较长时间才能结束，到时出现end 
