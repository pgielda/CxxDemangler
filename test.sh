if [ "$#" -eq "0" ] ; then
 echo "usage: test.sh /path/to/file.elf"
 exit 1
fi

readelf -s -W $1  | rev | cut -f 1 -d ' ' | rev | sort | uniq | grep "^_" | xargs mono GccDemanglingTest.exe > compare_mono
readelf -s -W $1  | rev | cut -f 1 -d ' ' | rev | sort | uniq | grep "^_" | c++filt > compare_cppfilt

diff compare_* -y -W 200
