def parse(text:str):
  var = ''
  varCount=0
  groupCount=0
  tree = []
  text.replace(' ', '')
  print(text)
  for i in text:
    print(i)
    if len(tree) == 0:
      tree.append(i)
    elif i.isdigit():
      if tree[-1].isdigit():
        tree[-1] += i
      else:
        tree.append(i)
    elif i in '+-*/^':
      tree.append(i)
    elif i in '()':
      if i == '(' and tree[-1].isdigit():
          tree.append('*')
          tree.append(i)
          groupCount += 1
      else:
          if groupCount > 0 and tree[-1] not in '+-*/^':
            tree.append(i)
            groupCount -= 1
    elif i.isalpha():
      varCount += 1
      if var == '':
        var = i
        tree.append(i)
      elif i == var:
        tree.append(i)
      else:
        print('Error: Cannot process more than one variable')
  return tree

# print(parse('5x^2 + 4(1-x)'))