# Generated by Django 2.2.5 on 2020-09-10 07:50

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('SendItApp', '0015_auto_20200909_2146'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='attempt',
            name='shoes',
        ),
    ]